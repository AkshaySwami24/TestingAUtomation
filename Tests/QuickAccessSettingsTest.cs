using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talisma_Automation.Pages;
using Talisma_Automation.Tests;
using OpenQA.Selenium;
using System.Threading;

namespace Talisma_Automation.Tests
{
    [TestFixture]
    //[Parallelizable(ParallelScope.Fixtures)]
    public class SettingsTest : BasePageTest
    {

            private QuickAccessSettingsPage QuickAccessSettingsPage;
            private LoginPage LoginPage;
            //private DashboardPage DashboardPage;


            [SetUp]
            public void SetupFixture()
            {
                QuickAccessSettingsPage = new QuickAccessSettingsPage(driver);
                LoginPage = new LoginPage(driver);

            }

            [Test]
            public void TestnavigatetoSettings()
            {
                LoginPage.LoginToApp("a", "a");
                Thread.Sleep(2000);
                if (LoginPage.IsAlertPresent())
                {
                    LoginPage.CloseAlert();
                }
                QuickAccessSettingsPage.navigatetoSessting();
                
                QuickAccessSettingsPage.clickOnWorkspaceManager();
                Thread.Sleep(5000);
              
            // testing the github changes chnges

            }
        

    }
}
