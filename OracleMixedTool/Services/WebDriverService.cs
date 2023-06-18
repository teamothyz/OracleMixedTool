using ChromeDriverLibrary;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OracleMixedTool.Models;
using SeleniumUndetectedChromeDriver;

namespace OracleMixedTool.Services
{
    public class WebDriverService
    {
        public static int DefaultTimeout { get; set; } = 30;
        public static int DefaultWaitChangePass { get; set; } = 5;
        public static int DefaultWaitDelete { get; set; } = 60;
        public static int DefaultWaitReboot { get; set; } = 60;
        public static int DefaultWaitCreateNew { get; set; } = 60;

        public static async Task<Tuple<bool, string>> EnterTenant(UndetectedChromeDriver driver, Account account, CancellationToken token)
        {
            var url = $"https://cloud.oracle.com/?tenant={account.Email.Split('@')[0]}";
            try
            {
                driver.GoToUrl(url);
                await HandleCookieAccept(driver, token);
                await Task.Delay(DefaultTimeout * 1000, token);

                if (driver.Url.Contains("oraclecloud.com/v1/oauth2/authorize"))
                {
                    var submitFederationBtn = driver.FindElement("#submit-federation", DefaultTimeout, token);
                    await Task.Delay(3000, token);

                    driver.Click(submitFederationBtn, DefaultTimeout, token);
                    await Task.Delay(3000, token);

                    driver.FindElement("#idcs-signin-basic-signin-form-submit > button > div", DefaultTimeout * 2, token);
                }

                if (driver.Url.Contains("identity.oraclecloud.com/ui/v1/signin")) return Tuple.Create(true, string.Empty);
                else return Tuple.Create(false, $"can not load page: {url}");
            }
            catch (Exception ex)
            {
                DataHandler.WriteLog("[EnterTenant]", ex);
                return Tuple.Create(false, $"[EnterTenant] {ex.Message}");
            }
        }

        private static async Task HandleCookieAccept(UndetectedChromeDriver driver, CancellationToken token)
        {
            try
            {
                var iframe = driver.FindElement(@"iframe[name=""trustarc_cm""]", DefaultTimeout, token);
                driver.SwitchTo().Frame(iframe);
                await Task.Delay(3000, token);

                var acceptBtn = driver.FindElement("a.call", DefaultTimeout, token);
                await Task.Delay(3000, token);

                driver.Click(acceptBtn, DefaultTimeout, token);
                await Task.Delay(3000, token);

                driver.SwitchTo().DefaultContent();
            }
            catch (Exception ex)
            {
                DataHandler.WriteLog("[HandleCookieAccept]", ex);
            }
        }

        public static async Task<Tuple<bool, string, string>> Login(UndetectedChromeDriver driver, Account account, CancellationToken token)
        {
            try
            {
                var emailInputElm = driver.FindElement("#idcs-signin-basic-signin-form-username", DefaultTimeout, token);
                await Task.Delay(3000, token);
                driver.Sendkeys(emailInputElm, account.Email, true, DefaultTimeout, token);

                var passInputElm = driver.FindElement(@"input[id=""idcs-signin-basic-signin-form-password|input""]", DefaultTimeout, token);
                await Task.Delay(3000, token);
                driver.Sendkeys(passInputElm, account.Password, true, DefaultTimeout, token);

                var tenantUrl = driver.Url.Split(".identity.oraclecloud.com")[0];
                var button = driver.FindElement("#idcs-signin-basic-signin-form-submit > button > div", DefaultTimeout, token);
                await Task.Delay(3000, token);
                driver.Click(button, DefaultTimeout, token);

                await Task.Delay(DefaultTimeout * 1000, token);
                if (driver.Url.Contains("https://cloud.oracle.com/?region=")) return Tuple.Create(true, string.Empty, tenantUrl);
                if (driver.Url.Contains("identity.oraclecloud.com/ui/v1/pwdmustchange")) return Tuple.Create(true, "pwdmustchange", tenantUrl);
                if (driver.Url.Contains("oraclecloud.com/ui/v1/signin")) return Tuple.Create(false, "login failed or can not load the next page", string.Empty);
                else return Tuple.Create(false, "login failed or can not load the next page", string.Empty);
            }
            catch (Exception ex)
            {
                DataHandler.WriteLog("[Login]", ex);
                return Tuple.Create(false, $"[Login] {ex.Message}", string.Empty);
            }
        }

        public static async Task<Tuple<bool, string>> ChangePasswordMustChange(UndetectedChromeDriver driver, Account account, CancellationToken token)
        {
            try
            {
                var oldPassElm = driver.FindElement(@"[id=""idcs-unauthenticated-reset-password-old-password|input""]", DefaultTimeout, token);
                await Task.Delay(3000, token);
                driver.Sendkeys(oldPassElm, account.Password, true, DefaultTimeout, token);

                var newPassElm = driver.FindElement(@"[id=""idcs-unauthenticated-reset-password-new-password|input""]", DefaultTimeout, token);
                await Task.Delay(3000, token);
                driver.Sendkeys(newPassElm, account.Password + account.PasswordIndex, true, DefaultTimeout, token);

                var confirmPassElm = driver.FindElement(@"[id=""idcs-unauthenticated-reset-password-confirm-password|input""]", DefaultTimeout, token);
                await Task.Delay(3000, token);
                driver.Sendkeys(confirmPassElm, account.Password + account.PasswordIndex, true, DefaultTimeout, token);

                var btnElm = driver.FindElement(@"[id=""idcs-unauthenticated-reset-password-submit-button""]", DefaultTimeout, token);
                await Task.Delay(3000, token);
                driver.Click(btnElm, DefaultTimeout, token);

                await Task.Delay(DefaultTimeout * 1000, token);
                if (driver.Url.Contains("oracle.com/cloud/sign-in"))
                {
                    var accountNameElm = driver.FindElement("#cloudAccountName", DefaultTimeout, token);
                    driver.Sendkeys(accountNameElm, account.Email.Split('@')[0], true, DefaultTimeout, token);
                    await Task.Delay(3000, token);

                    var button = driver.FindElement("#cloudAccountButton", DefaultTimeout, token);
                    driver.Click(button, DefaultTimeout, token);
                    await Task.Delay(DefaultTimeout * 1000, token);
                }

                if (driver.Url.Contains("https://cloud.oracle.com/?region="))
                {
                    account.PasswordIndex++;
                    return Tuple.Create(true, driver.Url);
                }
                else return Tuple.Create(false, $"change password failed. Old pass: {account.Password}, new pass: {account.Password + account.PasswordIndex}");
            }
            catch (Exception ex)
            {
                DataHandler.WriteLog("[ChangePassword]", ex);
                return Tuple.Create(false, $"[ChangePassword] {ex.Message}. Old pass: {account.Password}, new pass: {account.Password + account.PasswordIndex}");
            }
        }

        public static async Task<Tuple<bool, string>> ChangePassword(UndetectedChromeDriver driver, string tenantUrl, Account account, CancellationToken token)
        {
            try
            {
                driver.GoToUrl($"{tenantUrl}.identity.oraclecloud.com/ui/v1/myconsole?root=my-info&my-info=change_password");
                await Task.Delay(3000, token);
                while (true)
                {
                    var oldPass = account.Password + (account.PasswordIndex - 1);
                    var newPass = account.PasswordIndex == 5 ? account.NewPassword : account.Password + account.PasswordIndex;

                    var oldPassElm = driver.FindElement("#oldpassword", DefaultTimeout, token);
                    await Task.Delay(3000, token);
                    driver.Sendkeys(oldPassElm, oldPass, true, DefaultTimeout, token);

                    var newPasswordElm = driver.FindElement("#mipwdpassword", DefaultTimeout, token);
                    await Task.Delay(3000, token);
                    driver.Sendkeys(newPasswordElm, newPass, true, DefaultTimeout, token);

                    var confirmPasswordElm = driver.FindElement("#cpassword", DefaultTimeout, token);
                    await Task.Delay(3000, token);
                    driver.Sendkeys(confirmPasswordElm, newPass, true, DefaultTimeout, token);

                    var btnElm = driver.FindElement("#submitbutton", DefaultTimeout, token);
                    await Task.Delay(3000, token);
                    driver.Click(btnElm, DefaultTimeout, token);

                    var timeOut = DateTime.Now.AddSeconds(DefaultTimeout);

                    var success = false;
                    while (DateTime.Now < timeOut)
                    {
                        if (string.IsNullOrEmpty(oldPassElm.GetAttribute("value")))
                        {
                            account.PasswordIndex++;
                            success = true;
                            break;
                        }
                        await Task.Delay(1000, token);
                    }
                    if (!success) return Tuple.Create(false, $"change pass failed. Oldpass: {account.Password}, newPass {newPass}");
                    if (account.PasswordIndex == 6) return Tuple.Create(true, string.Empty);
                }
            }
            catch (Exception ex)
            {
                DataHandler.WriteLog("[ChangePassword]", ex);
                return Tuple.Create(false, $"[ChangePassword] {ex.Message}. Oldpass: {account.Password}, newPass {account.NewPassword}");
            }
        }

        public static async Task<Tuple<bool, string>> GoToInstancesPage(UndetectedChromeDriver driver, CancellationToken token)
        {
            try
            {
                driver.GoToUrl("https://cloud.oracle.com/compute/instances");
                await Task.Delay(DefaultTimeout * 1000 / 2, token);

                var compartmentElm = driver.FindElement(@"[aria-label=""Compartment""]", DefaultTimeout, token);
                await Task.Delay(3000, token);
                driver.Click(compartmentElm, DefaultTimeout, token);

                var rootElm = driver.FindElement(@"[title*=""(root)""]", DefaultTimeout, token);
                await Task.Delay(3000, token);
                driver.Click(rootElm, DefaultTimeout, token);
                return Tuple.Create(true, string.Empty);
            }
            catch (Exception ex)
            {
                DataHandler.WriteLog("[GoToInstancesPage]", ex);
                return Tuple.Create(false, $"[GoToInstancesPage] {ex.Message}");
            }
        }

        public static async Task<Tuple<bool, string>> DeleteAndReboot(UndetectedChromeDriver driver, Account account, string ssh, CancellationToken token)
        {
            try
            {
                driver.GoToUrl("https://cloud.oracle.com/compute/instances");
                await Task.Delay(DefaultTimeout * 1000 / 2, token);

                var iframe = driver.FindElement("#sandbox-compute-container", DefaultTimeout, token);
                await Task.Delay(3000, token);
                driver.SwitchTo().Frame(iframe);

                _ = driver.FindElement(@"[role=""table""]", DefaultTimeout, token);
                await Task.Delay(3000, token);

                var instancesElm = driver.FindElements(By.CssSelector("table tbody tr"));
                var index = 1;

                foreach (var instanceElm in instancesElm)
                {
                    token.ThrowIfCancellationRequested();
                    await HandleDeleteOrReboot(driver, account, index, instanceElm, token);
                    index++;
                }

                if (string.IsNullOrEmpty(account.ToBeCreateInstance))
                {
                    var createBtn = driver.FindElement(".chakra-stack .chakra-button:nth-child(1)", DefaultTimeout, token);
                    await Task.Delay(1000, token);
                    driver.Click(createBtn, DefaultTimeout, token);

                    await HandleShapeImage(driver, account, token);
                    await HandleNetwork(driver, token);
                    await HandleSSHKey(driver, ssh, token);
                }
                return Tuple.Create(true, string.Empty);
            }
            catch (Exception ex)
            {
                DataHandler.WriteLog("[DeleteAndReboot]", ex);
                return Tuple.Create(false, $"[DeleteAndReboot] {ex.Message}");
            }
        }

        private static async Task HandleShapeImage(UndetectedChromeDriver driver, Account account, CancellationToken token)
        {
            var shapeAndImgBtn = driver.FindElement(@"[data-test-id=""image-shape-fieldset""]", DefaultTimeout, token);
            await Task.Delay(1000, token);
            driver.Click(shapeAndImgBtn, DefaultTimeout, token);

            var changeImgBtn = driver.FindElement(@"[data-test-id=""change-image-button""]", DefaultTimeout, token);
            await Task.Delay(1000, token);
            driver.Click(changeImgBtn, DefaultTimeout, token);

            var osBtn = driver.FindElement(@"[value=""Canonical Ubuntu""]", DefaultTimeout, token);
            await Task.Delay(1000, token);
            driver.Click(osBtn, DefaultTimeout, token);

            var ubuntu2004 = driver.FindElement(@"[aria-label=""Select row Canonical Ubuntu 20.04""]", DefaultTimeout, token);
            await Task.Delay(1000, token);
            driver.Click(ubuntu2004, DefaultTimeout, token);

            var saveImgBtn = driver.FindElement(@"[role=""dialog""][aria-label=""Select an image""] .oui-savant__Panel--Footer button", DefaultTimeout, token);
            await Task.Delay(1000, token);
            driver.Click(saveImgBtn, DefaultTimeout, token);

            var changeShapeBtn = driver.FindElement(@"[data-test-id=""change-shape-button""]", DefaultTimeout, token);
            await Task.Delay(1000, token);
            driver.Click(changeShapeBtn, DefaultTimeout, token);

            if (account.Image == ImgType.Ampere)
            {
                var ampereBtn = driver.FindElement(@"[data-test-id=""ampere""]", DefaultTimeout, token);
                await Task.Delay(1000, token);
                driver.Click(ampereBtn, DefaultTimeout, token);

                var selectShapeNameBtn = driver.FindElement(@"[aria-label=""Select row VM.Standard.A1.Flex""]", DefaultTimeout, token);
                await Task.Delay(1000, token);
                driver.Click(selectShapeNameBtn, DefaultTimeout, token);

                var actions = new Actions(driver);

                var cpuSlider = driver.FindElement(".slider-VM_Standard_A1_Flexcores .rc-slider", DefaultTimeout, token);
                var cpuSliderHandler = driver.FindElement(".slider-VM_Standard_A1_Flexcores .rc-slider-handle-2", DefaultTimeout, token);
                actions.ClickAndHold(cpuSliderHandler)
                    .MoveToElement(cpuSlider, cpuSlider.Size.Width, 0)
                    .Release()
                    .Perform();

                await Task.Delay(1000, token);

                var memorySlider = driver.FindElement(".slider-VM_Standard_A1_Flexmemory .rc-slider", DefaultTimeout, token);
                var memorySliderHandler = driver.FindElement(".slider-VM_Standard_A1_Flexmemory .rc-slider-handle-2", DefaultTimeout, token);
                actions.ClickAndHold(memorySliderHandler)
                    .MoveToElement(memorySlider, memorySlider.Size.Width, 0)
                    .Release()
                    .Perform();
            }
            else if (account.Image == ImgType.Other)
            {
                var ampereBtn = driver.FindElement(@"[data-test-id=""other""]", DefaultTimeout, token);
                await Task.Delay(1000, token);
                driver.Click(ampereBtn, DefaultTimeout, token);
            }

            var selectShapeBtn = driver.FindElement(@"[aria-label=""Browse all shapes""] .oui-savant__Panel--Footer button", DefaultTimeout, token);
            await Task.Delay(1000, token);
            driver.Click(selectShapeBtn, DefaultTimeout, token);
        }

        public static async Task HandleNetwork(UndetectedChromeDriver driver, CancellationToken token)
        {
            var networkEditBtn = driver.FindElement(@"[data-test-id=""network-fieldset""] button", DefaultTimeout, token);
            await Task.Delay(1000, token);
            driver.Click(networkEditBtn, DefaultTimeout, token);

            bool needCreate;
            try
            {
                _ = driver.FindElement(@"[name=""subnetId""] optgroup[label=""Public subnets""] option", 10, token);
                needCreate = false;
            }
            catch { needCreate = true; }

            if (needCreate)
            {
                var newNetworkElm = driver.FindElement(@"[data-test-id=""new-vcn""]", DefaultTimeout, token);
                await Task.Delay(1000, token);
                driver.Click(newNetworkElm, DefaultTimeout, token);

                var newVCloudNetworkElm = driver.FindElement(@"[name=""vcnName""]", DefaultTimeout, token);
                await Task.Delay(1000, token);
                driver.Sendkeys(newVCloudNetworkElm, "Network-1", false, DefaultTimeout, token);

                var newSubnetNameElm = driver.FindElement(@"[name=""subnetName""]", DefaultTimeout, token);
                await Task.Delay(1000, token);
                driver.Sendkeys(newSubnetNameElm, "Network-1", false, DefaultTimeout, token);
            }
        }

        public static async Task HandleSSHKey(UndetectedChromeDriver driver, string key, CancellationToken token)
        {
            var sshElm = driver.FindElement(@"[id=""oui-radio-ssh-key-from-textarea""]", DefaultTimeout, token);
            await Task.Delay(1000, token);
            driver.Click(sshElm, DefaultTimeout, token);

            var sshInputElm = driver.FindElement(@"[name=""sshKey""]", DefaultTimeout, token);
            await Task.Delay(1000, token);
            driver.Sendkeys(sshInputElm, key, true, DefaultTimeout, token);
        }

        private static async Task HandleDeleteOrReboot(UndetectedChromeDriver driver,
            Account account,
            int index,
            IWebElement element,
            CancellationToken token)
        {
            try
            {
                var instanceInfo = driver.GetInnerText(element);
                var deleted = false;

                foreach (var tobeDelete in account.ToBeDeleteInstances)
                {
                    if (instanceInfo.Contains(tobeDelete))
                    {
                        var actionBtn = element.FindElement(By.CssSelector("td:nth-child(11) button"));
                        await Task.Delay(3000, token);
                        driver.Click(actionBtn, DefaultTimeout, token);

                        var deleteBtn = driver.FindElement(@$"body menu:nth-child({index}) div:nth-child(6) button div button", DefaultTimeout, token);
                        await Task.Delay(3000, token);
                        driver.Click(deleteBtn, DefaultTimeout, token);

                        var deleteVolumeBtn = driver.FindElement(@"[name=""delete-volume-field""]", DefaultTimeout, token);
                        await Task.Delay(3000, token);
                        driver.Click(deleteVolumeBtn, DefaultTimeout, token);

                        var deletedConfirmBtn = driver.FindElement(@"[type=""submit""]", DefaultTimeout, token);
                        await Task.Delay(3000, token);
                        driver.Click(deletedConfirmBtn, DefaultTimeout, token);

                        deleted = true;
                        break;
                    }
                }

                if (deleted) return;

                foreach (var tobeReboot in account.ToBeDeleteInstances)
                {
                    if (instanceInfo.Contains(tobeReboot))
                    {
                        var actionBtn = element.FindElement(By.CssSelector("td:nth-child(11) button"));
                        await Task.Delay(3000, token);
                        driver.Click(actionBtn, DefaultTimeout, token);

                        var rebootBtn = driver.FindElement(@$"body menu:nth-child({index}) div:nth-child(4) button div button", DefaultTimeout, token);
                        await Task.Delay(3000, token);
                        driver.Click(rebootBtn, DefaultTimeout, token);

                        var forceRebootBtn = driver.FindElement(@"[name=""force-reboot-instance-field""]", DefaultTimeout, token);
                        await Task.Delay(3000, token);
                        driver.Click(forceRebootBtn, DefaultTimeout, token);

                        var rebootConfirmBtn = driver.FindElement(@"[type=""submit""]", DefaultTimeout, token);
                        await Task.Delay(3000, token);
                        driver.Click(rebootConfirmBtn, DefaultTimeout, token);
                        break;
                    }
                }
            }
            catch { }
        }
    }
}