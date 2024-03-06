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
   // [Parallelizable(ParallelScope.Fixtures)]
    public class LoginPageTest : BasePageTest
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
        [TestCase("","")]
        
        public void LoginWithInvalidUsernameAndPassword(string username, string password)
        {
            LoginPage.LoginToApp(username, password);
            Thread.Sleep(5000);//Temp wait for demo
            LoginPage.CloseAlert();
           
            Assert.Multiple(() =>
            {
                Assert.IsTrue(LoginPage.Login_Button.IsElementDisplayed());
            });
            
            GoToLoginPage();
        }

    }
}
