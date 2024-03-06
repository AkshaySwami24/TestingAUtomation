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
    public class CampaignWorkspaceCreationTest : BasePageTest
    {
        private LoginPage LoginPage;
        private CampaignWorkspaceCreationPage CampaignWorkspaceCreationPage;
        private AccountWorkspaceCreationPage AccountWorkspaceCreationPage;
        private QuickAccessSettingsPage QuickAccessSettingsPage;
        private WorkspaceManagerMenuOptionsPage WorkspaceManagerMenuOptionsPage;
        private AccountWorkspaceMenuOperationsPage AccountWorkspaceMenuOperationsPage;


        [SetUp]
        public void SetupFixture()
        {
            AccountWorkspaceCreationPage = new AccountWorkspaceCreationPage(driver);
            CampaignWorkspaceCreationPage = new CampaignWorkspaceCreationPage(driver);
            LoginPage = new LoginPage(driver);
            QuickAccessSettingsPage = new QuickAccessSettingsPage(driver);
            WorkspaceManagerMenuOptionsPage = new WorkspaceManagerMenuOptionsPage(driver);
        }
        [Test, Order(1)]
        public void CreateCampaignWorkspace()
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
            CampaignWorkspaceCreationPage.EnterWorkspaceName();
            AccountWorkspaceCreationPage.selectBaseObject();
            CampaignWorkspaceCreationPage.selectBaseObjectOption();
            AccountWorkspaceCreationPage.AddviewToWorkspacemanager();
            AccountWorkspaceCreationPage.AddTableviewToWorkspacemanager();
            AccountWorkspaceCreationPage.ClickonTableviewtoconfigure();
            Thread.Sleep(3000);
            AccountWorkspaceCreationPage.selectBaseObjecttoConfigureTV();
            CampaignWorkspaceCreationPage.selectObjectfromOption();
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
                CampaignWorkspaceCreationPage.SelectWOrkspace();
                GenericMethod.SaveScreenShot(driver, "CreateCampaignWorkspace");
                Console.WriteLine(ex.Message);
            }
        }

        [Test, Order(2)]
        public void PerformViewMenuOperationsOnCampaignWorkspace()
        {
            LoginPage.LoginToApp("a", "a");
            Thread.Sleep(2000);
            if (LoginPage.IsAlertPresent())
            {
                LoginPage.CloseAlert();
            }
            QuickAccessSettingsPage.navigatetoSessting();

            QuickAccessSettingsPage.clickOnWorkspaceManager();
            CampaignWorkspaceCreationPage.SelectWOrkspace();
            WorkspaceManagerMenuOptionsPage.ViewWorkspace();
            Thread.Sleep(4000);
            String title = driver.Title;
            Console.WriteLine(title);
            GenericMethod.SaveScreenShot(driver, "PerformViewMenuOperationsOnCampaignWorkspace");

        }

        [Test, Order(3)]
        public void PerformEditMenuOperationsOnCampaignWorkspace()
        {
            LoginPage.LoginToApp("a", "a");
            Thread.Sleep(2000);
            if (LoginPage.IsAlertPresent())
            {
                LoginPage.CloseAlert();
            }
            QuickAccessSettingsPage.navigatetoSessting();

            QuickAccessSettingsPage.clickOnWorkspaceManager();
            CampaignWorkspaceCreationPage.SelectWOrkspace();
            WorkspaceManagerMenuOptionsPage.EditWorkspaceToModify();
            Thread.Sleep(4000);
            GenericMethod.SaveScreenShot(driver, "PerformEditMenuOperationsOnCampaignWorkspace");
        }

        [Test, Order(4)]
        public void PerformRenameMenuOperationsOnCampaignWorkspace()
        {
            LoginPage.LoginToApp("a", "a");
            Thread.Sleep(2000);
            if (LoginPage.IsAlertPresent())
            {
                LoginPage.CloseAlert();
            }
            QuickAccessSettingsPage.navigatetoSessting();

            QuickAccessSettingsPage.clickOnWorkspaceManager();

            CampaignWorkspaceCreationPage.SelectWOrkspace();
            Thread.Sleep(3000);
            WorkspaceManagerMenuOptionsPage.RenameExistingWorkspace();
            Thread.Sleep(4000);
            AccountWorkspaceMenuOperationsPage.RenameWorkspace();
        }
        [Test, Order(5)]
        public void PerformDeleteMenuOperationsOnCampaignWorkspace()
        {
            LoginPage.LoginToApp("a", "a");
            Thread.Sleep(2000);
            if (LoginPage.IsAlertPresent())
            {
                LoginPage.CloseAlert();
            }
            QuickAccessSettingsPage.navigatetoSessting();

            QuickAccessSettingsPage.clickOnWorkspaceManager();

            CampaignWorkspaceCreationPage.SelectWOrkspace();
            Thread.Sleep(3000);
            WorkspaceManagerMenuOptionsPage.DeleteSelectedWorkspace();
            Thread.Sleep(4000);
            WorkspaceManagerMenuOptionsPage.DeleteWorkspaceFromWorkspaceManager();
            Thread.Sleep(4000);
            GenericMethod.SaveScreenShot(driver, "PerformDeleteMenuOperationsOnCampaignWorkspace");
        }
    }
}
