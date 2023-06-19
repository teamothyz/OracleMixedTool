using ChromeDriverLibrary;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OracleMixedTool.Forms;
using OracleMixedTool.Models;
using OracleMixedTool.Services;

namespace OracleMixedTool
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var frmMain = new FrmMain
            {
                TopMost = true
            };
            Application.Run(frmMain);
        }
    }
}