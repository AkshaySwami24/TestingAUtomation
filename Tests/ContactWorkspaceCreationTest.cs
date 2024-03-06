using IronXL;
using NUnit.Framework;
using NUnit.Framework.Internal.Execution;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
   // [Parallelizable(ParallelScope.Fixtures)]
    public class ContactWorkspaceCreationTest : BasePageTest
    {
        private LoginPage LoginPage;
        private ContactWorkspaceCreationPage ContactWorkspaceCreationPage;
        private AccountWorkspaceCreationPage AccountWorkspaceCreationPage;
        private QuickAccessSettingsPage QuickAccessSettingsPage;
        private WorkspaceManagerMenuOptionsPage WorkspaceManagerMenuOptionsPage;
        private AccountWorkspaceMenuOperationsPage AccountWorkspaceMenuOperationsPage;


        [SetUp]
        public void SetupFixture()
        {
            AccountWorkspaceCreationPage = new AccountWorkspaceCreationPage(driver);
            ContactWorkspaceCreationPage = new ContactWorkspaceCreationPage(driver);
            LoginPage = new LoginPage(driver);
            QuickAccessSettingsPage = new QuickAccessSettingsPage(driver);
            WorkspaceManagerMenuOptionsPage = new WorkspaceManagerMenuOptionsPage(driver);
        }
        [Test,Order(1)]
        public void CreateContactWorkspace()
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
            ContactWorkspaceCreationPage.EnterWorkspaceName();
            AccountWorkspaceCreationPage.selectBaseObject();
            ContactWorkspaceCreationPage.selectBaseObjectOption();
            AccountWorkspaceCreationPage.AddviewToWorkspacemanager();
            AccountWorkspaceCreationPage.AddTableviewToWorkspacemanager();
            AccountWorkspaceCreationPage.ClickonTableviewtoconfigure();
            Thread.Sleep(3000);
            AccountWorkspaceCreationPage.selectBaseObjecttoConfigureTV();
            ContactWorkspaceCreationPage.selectObjectfromOption();
            Thread.Sleep(3000);
            AccountWorkspaceCreationPage.ClickOKonceTableViewisconfigured();
            Thread.Sleep(3000);
            AccountWorkspaceCreationPage.ClickOKtoCreateWorkspace();
            

            try
            {
                //wait.until(ExpectedConditions.alertIsPresent())

                IAlert simpleAlert = driver.SwitchTo().Alert();
                String alertText = simpleAlert.Text;
                Console.WriteLine("Alert text is " + alertText);
                simpleAlert.Accept();
            }
            catch (Exception ex)
            {

                Thread.Sleep(3000);
                ContactWorkspaceCreationPage.SelectWOrkspace();
                GenericMethod.SaveScreenShot(driver, "CreateContactWorkspace");
                Console.WriteLine(ex.Message);
            }
        }

        [Test,Order(2)]
        public void PerformViewMenuOperationsOnContactWorkspace()
        {
                // string ExpectedTitle = "Talisma_Automation_AccountWorkspace";
                LoginPage.LoginToApp("a", "a");
                Thread.Sleep(2000);
                if (LoginPage.IsAlertPresent())
                {
                    LoginPage.CloseAlert();
                }
                QuickAccessSettingsPage.navigatetoSessting();

                QuickAccessSettingsPage.clickOnWorkspaceManager();
 
                ContactWorkspaceCreationPage.SelectWOrkspace();

                WorkspaceManagerMenuOptionsPage.ViewWorkspace();
                Thread.Sleep(4000);

                String title = driver.Title;
                Console.WriteLine(title);
                GenericMethod.SaveScreenShot(driver, "PerformViewMenuOperationsOnContactWorkspace");

        }

        [Test, Order(3)]
        public void PerformEditMenuOperationsOnContactWorkspace()
        {
            LoginPage.LoginToApp("a", "a");
            Thread.Sleep(2000);
            if (LoginPage.IsAlertPresent())
            {
                LoginPage.CloseAlert();
            }
            QuickAccessSettingsPage.navigatetoSessting();

            QuickAccessSettingsPage.clickOnWorkspaceManager();
            ContactWorkspaceCreationPage.SelectWOrkspace();
            WorkspaceManagerMenuOptionsPage.EditWorkspaceToModify();
            Thread.Sleep(4000);
            GenericMethod.SaveScreenShot(driver, "PerformEditMenuOperationsOnContactWorkspace");
        }

        [Test, Order(4)]
        public void PerformRenameMenuOperationsOnContactWorkspace()
        {
            LoginPage.LoginToApp("a", "a");
            Thread.Sleep(2000);
            if (LoginPage.IsAlertPresent())
            {
                LoginPage.CloseAlert();
            }
            QuickAccessSettingsPage.navigatetoSessting();

            QuickAccessSettingsPage.clickOnWorkspaceManager();

            ContactWorkspaceCreationPage.SelectWOrkspace();
            Thread.Sleep(3000);
            WorkspaceManagerMenuOptionsPage.RenameExistingWorkspace();
            Thread.Sleep(4000);
            AccountWorkspaceMenuOperationsPage.RenameWorkspace();
        }

        [Test, Order(5)]
        public void PerformDeleteMenuOperationsOnContactWorkspace()
        {
            LoginPage.LoginToApp("a", "a");
            Thread.Sleep(2000);
            if (LoginPage.IsAlertPresent())
            {
                LoginPage.CloseAlert();
            }
            QuickAccessSettingsPage.navigatetoSessting();

            QuickAccessSettingsPage.clickOnWorkspaceManager();

            ContactWorkspaceCreationPage.SelectWOrkspace();
            Thread.Sleep(3000);
            WorkspaceManagerMenuOptionsPage.DeleteSelectedWorkspace();
            Thread.Sleep(4000);
            WorkspaceManagerMenuOptionsPage.DeleteWorkspaceFromWorkspaceManager();
            Thread.Sleep(4000);
            GenericMethod.SaveScreenShot(driver, "PerformDeleteMenuOperationsOnContactWorkspace");
        }

    }
}
