using ChromeDriverLibrary;
using OpenQA.Selenium;
using OracleMixedTool.Models;
using OracleMixedTool.Services;

namespace OracleMixedTool
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var driver = ChromeDriverInstance.GetInstance(0, 0, isHeadless: false, disableImg: false);
            if (driver.Item1 == null) return;
            var acc = new Account
            {
                Email = "mundovoip2010@gmail.com",
                Password = "EnMeVe#170303",
                NewpassWord = "EnMeVe#170303"
            };

            var token = CancellationToken.None;
            WebDriverService.EnterTenant(driver.Item1, acc, token).Wait();
            var rs = WebDriverService.Login(driver.Item1, acc, token).Result;
            if (rs.Item2 == "pwdmustchange")
            {
                var rs2 = WebDriverService.ChangePasswordMustChange(driver.Item1, acc, token).Result;
                var rs3 = WebDriverService.ChangePassword(driver.Item1, rs.Item3, acc, token).Result;
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}