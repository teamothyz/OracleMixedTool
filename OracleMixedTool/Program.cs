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
            var driver = ChromeDriverInstance.GetInstance(0, 0, isHeadless: false, disableImg: false);
            WebDriverService.DefaultTimeout = 15;
            var ssh = "ssh-rsa AAAAB3NzaC1yc2EAAAADAQABAAABAQDHqC2IuDMU82w9PDafyEVgH6knpEqktJ18E6kFPlC8xeGe99N7RuP1SxWo1wEtl2DQsdAjjfYl9RFOr+nks3HVUM6Svfh7WhGAVXlwsjp3mXZHJ5gXBJRIZXraIsUuG4HEvm4R67O7jQNN/QNEnyrBhv00p0bukXmjSHn50H52pRmMQ/2X1YeK5NHGyA4eVyhXvuy9evv+UIRXPkAwpS4nd1D8lo55LB3UtvrsxveosNHevOxeHnlOsEokpUZuKrTwTHQpt2KSpjokUgIWjM9dmsEncgQ8TMuZqRn9L61l+dnFfu2wmtu53N0/GxyUCqERd/VG9DlqUO7x+kiZX7Ht";
            var acc = new Account
            {
                Email = "prakashmandekar8@gmail.com",
                Password = "EnMeVe#170303",
                NewPassword = "EnMeVe#170303"
            };
            acc.CurrentPassword = acc.Password;
            //acc.ToBeRebootInstances.Add("140.238.230.112");
            //acc.ToBeDeleteInstances.Add("140.238.244.173");
            acc.ToBeCreateInstance = "VPS-4";


            var token = CancellationToken.None;
            WebDriverService.EnterTenant(driver.Item1, acc, token).Wait();
            var rs = WebDriverService.Login(driver.Item1, acc, token).Result;
            if (rs.Item2 == "pwdmustchange")
            {
                var rs2 = WebDriverService.ChangePasswordMustChange(driver.Item1, acc, token).Result;
                var rs3 = WebDriverService.ChangePassword(driver.Item1, rs.Item3, acc, token).Result;
                driver.Item1.GoToUrl(rs2.Item2);
            }
            WebDriverService.DeleteRebootAndCreate(driver.Item1, acc, ssh, token).Wait();
            WebDriverService.CaptureInstance(driver.Item1, acc, token).Wait();
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
        }
    }
}