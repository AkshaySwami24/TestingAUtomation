using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Interfaces;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using IronXL;

namespace Talisma_Automation.Pages
{
    public class BasePage
    {
        public IWebDriver driver { get; private set; }
        public WebDriverWait wait { get; private set; }
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException E)
            {
                return false;
            }
        }

        public void CloseAlert()
        {
            var Close_Alert = driver.SwitchTo().Alert();
            Close_Alert.Accept();
        }
    }

    public class GenericMethod
    {
        private static ITakesScreenshot driver;

        public static void SaveScreenShot(IWebDriver drv, string testcasename)
        {

            var folderLocation = "C:\\Users\\AkshaySwami\\source\\repos\\Talisma_TestUI\\PassScreenshots\\";
            if (!Directory.Exists(folderLocation))
            {
                Directory.CreateDirectory(folderLocation);
            }
            ITakesScreenshot screenshot = drv as ITakesScreenshot;
            Screenshot Screen = screenshot.GetScreenshot();
            var filename = new StringBuilder(folderLocation);
            filename.Append($"{testcasename}");
            filename.Append(DateTime.Now.ToString("dd-mm-yyyy HH_mm_ss"));
            filename.Append(".png");
            Console.WriteLine(filename.ToString());
            Screen.SaveAsFile(filename.ToString());

        } 
    } 
}
