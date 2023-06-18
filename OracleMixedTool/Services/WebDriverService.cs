using ChromeDriverLibrary;
using OracleMixedTool.Models;
using SeleniumUndetectedChromeDriver;

namespace OracleMixedTool.Services
{
    public class WebDriverService
    {
        public static int DefaultTimeout { get; set; } = 30;

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
                return Tuple.Create(false, ex.Message);
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
                return Tuple.Create(false, ex.Message, string.Empty);
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
                    return Tuple.Create(true, string.Empty);
                }
                else return Tuple.Create(false, $"change password failed. Old pass: {account.Password}, new pass: {account.Password + account.PasswordIndex}");
            }
            catch (Exception ex)
            {
                DataHandler.WriteLog("[ChangePassword]", ex);
                return Tuple.Create(false, $"{ex.Message}. Old pass: {account.Password}, new pass: {account.Password + account.PasswordIndex}");
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
                    var newPass = account.PasswordIndex == 5 ? account.NewpassWord : account.Password + account.PasswordIndex;

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
                    if (account.PasswordIndex <= 5) continue;
                    if (account.PasswordIndex == 5) return Tuple.Create(true, string.Empty);
                }
            }
            catch (Exception ex)
            {
                DataHandler.WriteLog("[ChangePassword]", ex);
                return Tuple.Create(false, $"{ex.Message}. Oldpass: {account.Password}, newPass {account.NewpassWord}");
            }
        }
    }
}