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
   // [Parallelizable(ParallelScope.Fixtures)]
    public class OrderWorkspaceCreationTest : BasePageTest
    {
        private LoginPage LoginPage;
        private OrderWorkspaceCreationPage OrderWorkspaceCreationPage;
        private AccountWorkspaceCreationPage AccountWorkspaceCreationPage;
        private QuickAccessSettingsPage QuickAccessSettingsPage;
        private WorkspaceManagerMenuOptionsPage WorkspaceManagerMenuOptionsPage;
        private AccountWorkspaceMenuOperationsPage AccountWorkspaceMenuOperationsPage;


        [SetUp]
        public void SetupFixture()
        {
            AccountWorkspaceCreationPage = new AccountWorkspaceCreationPage(driver);
            OrderWorkspaceCreationPage = new OrderWorkspaceCreationPage(driver);
            LoginPage = new LoginPage(driver);
            QuickAccessSettingsPage = new QuickAccessSettingsPage(driver);
            WorkspaceManagerMenuOptionsPage = new WorkspaceManagerMenuOptionsPage(driver);
        }
        [Test, Order(1)]
        public void CreateOrderWorkspace()
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
            OrderWorkspaceCreationPage.EnterWorkspaceName();
            AccountWorkspaceCreationPage.selectBaseObject();
            OrderWorkspaceCreationPage.selectBaseObjectOption();
            AccountWorkspaceCreationPage.AddviewToWorkspacemanager();
            AccountWorkspaceCreationPage.AddTableviewToWorkspacemanager();
            AccountWorkspaceCreationPage.ClickonTableviewtoconfigure();
            Thread.Sleep(3000);
            AccountWorkspaceCreationPage.selectBaseObjecttoConfigureTV();
            OrderWorkspaceCreationPage.selectObjectfromOption();
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
                OrderWorkspaceCreationPage.SelectWOrkspace();
                Thread.Sleep(3000);
                GenericMethod.SaveScreenShot(driver, "CreateOrderWorkspace");
                Console.WriteLine(ex.Message);
            }
        }

        [Test, Order(2)]
        public void PerformViewMenuOperationsOnOrderWorkspace()
        {
            LoginPage.LoginToApp("a", "a");
            Thread.Sleep(2000);
            if (LoginPage.IsAlertPresent())
            {
                LoginPage.CloseAlert();
            }
            QuickAccessSettingsPage.navigatetoSessting();

            QuickAccessSettingsPage.clickOnWorkspaceManager();
            OrderWorkspaceCreationPage.SelectWOrkspace();
            WorkspaceManagerMenuOptionsPage.ViewWorkspace();
            Thread.Sleep(4000);
            String title = driver.Title;
            Console.WriteLine(title);
            GenericMethod.SaveScreenShot(driver, "PerformViewMenuOperationsOnOrderWorkspace");

        }

        [Test, Order(3)]
        public void PerformEditMenuOperationsOnOrderWorkspace()
        {
            LoginPage.LoginToApp("a", "a");
            Thread.Sleep(2000);
            if (LoginPage.IsAlertPresent())
            {
                LoginPage.CloseAlert();
            }
            QuickAccessSettingsPage.navigatetoSessting();

            QuickAccessSettingsPage.clickOnWorkspaceManager();
            OrderWorkspaceCreationPage.SelectWOrkspace();
            WorkspaceManagerMenuOptionsPage.EditWorkspaceToModify();
            Thread.Sleep(4000);
            GenericMethod.SaveScreenShot(driver, "PerformEditMenuOperationsOnOrderWorkspace");
        }

        [Test, Order(4)]
        public void PerformRenameMenuOperationsOnOrderWorkspace()
        {
            LoginPage.LoginToApp("a", "a");
            Thread.Sleep(2000);
            if (LoginPage.IsAlertPresent())
            {
                LoginPage.CloseAlert();
            }
            QuickAccessSettingsPage.navigatetoSessting();

            QuickAccessSettingsPage.clickOnWorkspaceManager();

            OrderWorkspaceCreationPage.SelectWOrkspace();
            Thread.Sleep(3000);
            WorkspaceManagerMenuOptionsPage.RenameExistingWorkspace();
            Thread.Sleep(4000);
            AccountWorkspaceMenuOperationsPage.RenameWorkspace();
        }

        [Test, Order(5)]
        public void PerformDeleteMenuOperationsOnOrderWorkspace()
        {
            LoginPage.LoginToApp("a", "a");
            Thread.Sleep(2000);
            if (LoginPage.IsAlertPresent())
            {
                LoginPage.CloseAlert();
            }
            QuickAccessSettingsPage.navigatetoSessting();

            QuickAccessSettingsPage.clickOnWorkspaceManager();

            OrderWorkspaceCreationPage.SelectWOrkspace();
            Thread.Sleep(3000);
            WorkspaceManagerMenuOptionsPage.DeleteSelectedWorkspace();
            Thread.Sleep(4000);
            WorkspaceManagerMenuOptionsPage.DeleteWorkspaceFromWorkspaceManager();
            Thread.Sleep(4000);
            GenericMethod.SaveScreenShot(driver, "PerformDeleteMenuOperationsOnOrderWorkspace");
        }
    }
}
