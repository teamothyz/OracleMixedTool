using ChromeDriverLibrary;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OracleMixedTool.Models;
using OracleMixedTool.Services;

namespace OracleMixedTool
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            //var driver = ChromeDriverInstance.GetInstance(0, 0, isHeadless: false, disableImg: false);
            var driver = ChromeDriverInstance.GetInstance(0, 0, isHeadless: false, disableImg: false).Item1;
            //var actions = new Actions(driver);
            var token = CancellationToken.None;
            var iframe = driver.FindElement("#sandbox-compute-container", 30, token);
            driver.SwitchTo().Frame(iframe);
            WebDriverService.HandleNetwork(driver, token).Wait();

            //var cpuSlider = driver.FindElement(".slider-VM_Standard_A1_Flexcores .rc-slider", 30, token);
            //var cpuSliderHandler = driver.FindElement(".slider-VM_Standard_A1_Flexcores .rc-slider-handle-2", 30, token);
            //actions.ClickAndHold(cpuSliderHandler)
            //    .MoveToElement(cpuSlider, cpuSlider.Size.Width, 0)
            //.Release()
            //    .Perform();
            //Task.Delay(1000, token).Wait();

            //var memorySlider = driver.FindElement(".slider-VM_Standard_A1_Flexmemory .rc-slider", 30, token);
            //var memorySliderHandler = driver.FindElement(".slider-VM_Standard_A1_Flexmemory .rc-slider-handle-2", 30, token);
            //actions.ClickAndHold(memorySliderHandler)
            //    .MoveToElement(memorySlider, memorySlider.Size.Width, 0)
            //    .Release()
            //    .Perform();

            //if (driver.Item1 == null) return;
            //var acc = new Account
            //{
            //    Email = "felixrico09@gmail.com",
            //    Password = "EnMeVe#170303",
            //    NewPassword = "EnMeVe#170303"
            //};

            //var token = CancellationToken.None;
            //WebDriverService.EnterTenant(driver.Item1, acc, token).Wait();
            //var rs = WebDriverService.Login(driver.Item1, acc, token).Result;
            //if (rs.Item2 == "pwdmustchange")
            //{
            //    var rs2 = WebDriverService.ChangePasswordMustChange(driver.Item1, acc, token).Result;
            //    var rs3 = WebDriverService.ChangePassword(driver.Item1, rs.Item3, acc, token).Result;
            //    driver.Item1.GoToUrl(rs2.Item2);
            //}
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
        }
    }
}