using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using Talisma_Automation.Pages;

namespace Talisma_Automation.Tests
{
    [TestFixture]
   // [Parallelizable]
    public class DashboardPageTest : BasePageTest
    {
        private LoginPage LoginPage;
        private DashboardPage DashboardPage;

        [SetUp]
        public void SetUpFixture()
        {
            LoginPage = new LoginPage(driver);
            DashboardPage = new DashboardPage(driver);
        }


        [Test]
        public void LoginAndVerifyTheDashboardPage()
        {
            string ExpectedTitle = "01-Dashboard";
            LoginPage.LoginToApp("vishwas", "vishwa");
            Thread.Sleep(5000);//Temp wait for demo
            if (LoginPage.IsAlertPresent())
            {
                LoginPage.CloseAlert();
            }
            
            Assert.Multiple(() =>
            {
                Assert.AreEqual(ExpectedTitle, DashboardPage.Dashboard_Option.GetText());
            });
            Thread.Sleep(5000);//Temp wait for demo
        }
    }
}
