using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using Talisma_Automation.Utils;

namespace Talisma_Automation.Tests
{
    public class BasePageTest
    {
        protected IWebDriver driver;
        private object settings;

        [SetUp]
        public void Setup()
        {
            driver = new DriverFactory().GetWebDriver("Edge");
            driver.Manage().Window.Maximize();
            GoToLoginPage();
        }

        [TearDown]
        public void OneTimeTearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                DateTime time = DateTime.Now;
                string dateToday = "_date_" + time.ToString("yyyy-MM-dd") + "_time_" + time.ToString("HH-mm-ss");
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                // screenshot.SaveAsFile(@"C:\Users\AkshaySwami\source\repos\Talisma_TestUI\FailedScreenshots\Failure1234.png");
                screenshot.SaveAsFile(@"C:\Users\AkshaySwami\source\repos\Talisma_TestUI\FailedScreenshots\Failure1234.png");

            }
            driver.Quit();
        }

        public void GoToLoginPage()
        {
            driver.Navigate().GoToUrl("https://srv1-crm12.saas.talismaonline.com/WebClient/login.aspx");

        }
    }
}
