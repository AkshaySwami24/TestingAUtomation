using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Talisma_Automation.Pages;
using Talisma_Automation.Tests;
using Talisma_TestUI.Pages;

namespace Talisma_TestUI.Tests
{
    [TestFixture]
    //[Parallelizable(ParallelScope.Fixtures)]
    public class AccountWorkspaceCreationTest : BasePageTest
    {
        private LoginPage LoginPage;
        private AccountWorkspaceCreationPage AccountWorkspaceCreationPage;
        private QuickAccessSettingsPage QuickAccessSettingsPage;
        private WorkspaceManagerMenuOptionsPage WorkspaceManagerMenuOptionsPage;


        [SetUp]
        public void SetupFixture()
        {
            AccountWorkspaceCreationPage = new AccountWorkspaceCreationPage(driver);
            LoginPage = new LoginPage(driver);
            QuickAccessSettingsPage  = new QuickAccessSettingsPage(driver);
            WorkspaceManagerMenuOptionsPage= new WorkspaceManagerMenuOptionsPage(driver);


        }
        [Test]
        public void CreateAccountWorkspace()
        {
            LoginPage.LoginToApp("a", "a");
            Thread.Sleep(2000);
            if (LoginPage.IsAlertPresent())
            {
                LoginPage.CloseAlert();
            }

            QuickAccessSettingsPage.navigatetoSessting();

            QuickAccessSettingsPage.clickOnWorkspaceManager();
            Thread.Sleep(3000);
            WorkspaceManagerMenuOptionsPage.newWorkspaceManager();
            Thread.Sleep(3000);
            AccountWorkspaceCreationPage.EnterWorkspaceName();

            AccountWorkspaceCreationPage.selectBaseObject();
            Thread.Sleep(3000);
            AccountWorkspaceCreationPage.selectBaseObjectOption();

            AccountWorkspaceCreationPage.AddviewToWorkspacemanager();

            AccountWorkspaceCreationPage.AddTableviewToWorkspacemanager();

            AccountWorkspaceCreationPage.ClickonTableviewtoconfigure();

            AccountWorkspaceCreationPage.selectBaseObjecttoConfigureTV();

            AccountWorkspaceCreationPage.selectObjectfromOption();
            
            AccountWorkspaceCreationPage.ClickOKonceTableViewisconfigured();

            AccountWorkspaceCreationPage.ClickOKtoCreateWorkspace();

            

            try
            {
              
                IAlert simpleAlert = driver.SwitchTo().Alert();
                String alertText = simpleAlert.Text;
                Console.WriteLine("Alert text is " + alertText);
                simpleAlert.Accept();
            }
            catch (Exception ex)
            {
                AccountWorkspaceCreationPage.SelectWOrkspace();
              
                GenericMethod.SaveScreenShot(driver, "CreateContactWorkspace");
                Console.WriteLine(ex.Message);
            }


        }

    }
}
