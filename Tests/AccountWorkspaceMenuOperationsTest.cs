using NUnit.Framework;
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
    public class AccountWorkspaceMenuOperationsTest : BasePageTest
    {
        private LoginPage LoginPage;
        private AccountWorkspaceMenuOperationsPage AccountWorkspaceMenuOperationsPage;
        private QuickAccessSettingsPage QuickAccessSettingsPage;
        private WorkspaceManagerMenuOptionsPage WorkspaceManagerMenuOptionsPage;
        private AccountWorkspaceCreationPage AccountWorkspaceCreationPage;


        [SetUp]
        public void SetupFixture()
        {
            AccountWorkspaceMenuOperationsPage = new AccountWorkspaceMenuOperationsPage(driver);
            LoginPage = new LoginPage(driver);
            QuickAccessSettingsPage = new QuickAccessSettingsPage(driver);
            WorkspaceManagerMenuOptionsPage = new WorkspaceManagerMenuOptionsPage(driver);
            AccountWorkspaceCreationPage = new AccountWorkspaceCreationPage(driver);

        }

        //[Test, Order(1)]
        //public void PerformViewMenuOperationsOnAccountWorkspace()
        //{
        //    // string ExpectedTitle = "Talisma_Automation_AccountWorkspace";
        //    LoginPage.LoginToApp("a", "a");
        //    Thread.Sleep(2000);
        //    if (LoginPage.IsAlertPresent())
        //    {
        //        LoginPage.CloseAlert();
        //    }
        //    QuickAccessSettingsPage.navigatetoSessting();

        //    QuickAccessSettingsPage.clickOnWorkspaceManager();

        //    AccountWorkspaceCreationPage.SelectWOrkspace();

        //    WorkspaceManagerMenuOptionsPage.ViewWorkspace();
        //    Thread.Sleep(4000);

        //    String title = driver.Title;
        //    Console.WriteLine(title);
        //    GenericMethod.SaveScreenShot(driver, "PerformViewMenuOperationsOnAccountWorkspace");

        //}

        //[Test, Order(2)]
        //public void PerformEditMenuOperationsOnAccountWorkspace()
        //{
        //    LoginPage.LoginToApp("a", "a");
        //    Thread.Sleep(2000);
        //    if (LoginPage.IsAlertPresent())
        //    {
        //        LoginPage.CloseAlert();
        //    }
        //    QuickAccessSettingsPage.navigatetoSessting();

        //    QuickAccessSettingsPage.clickOnWorkspaceManager();

        //    AccountWorkspaceCreationPage.SelectWOrkspace();
        //    Thread.Sleep(3000);
        //    WorkspaceManagerMenuOptionsPage.EditWorkspaceToModify();
        //    Thread.Sleep(4000);
        //    GenericMethod.SaveScreenShot(driver, "PerformEditMenuOperationsOnAccountWorkspace");
        //}

        [Test, Order(3)]
        public void PerformRenameMenuOperationsOnAccountWorkspace()
        {
            LoginPage.LoginToApp("a", "a");
            Thread.Sleep(2000);
            if (LoginPage.IsAlertPresent())
            {
                LoginPage.CloseAlert();
            }
            QuickAccessSettingsPage.navigatetoSessting();

            QuickAccessSettingsPage.clickOnWorkspaceManager();

            AccountWorkspaceCreationPage.SelectWOrkspace();
            Thread.Sleep(3000);
            WorkspaceManagerMenuOptionsPage.RenameExistingWorkspace();
            Thread.Sleep(4000);

            AccountWorkspaceMenuOperationsPage.RenameWorkspace();
            Thread.Sleep(4000);
            AccountWorkspaceMenuOperationsPage.ClearValueFromRenameWorkspace();

        }
        //[Test, Order(4)]
        //public void PerformDeleteMenuOperationsOnAccountWorkspace()
        //{
        //    LoginPage.LoginToApp("a", "a");
        //    Thread.Sleep(2000);
        //    if (LoginPage.IsAlertPresent())
        //    {
        //        LoginPage.CloseAlert();
        //    }
        //    QuickAccessSettingsPage.navigatetoSessting();

        //    QuickAccessSettingsPage.clickOnWorkspaceManager();

        //    AccountWorkspaceCreationPage.SelectWOrkspace();
        //    Thread.Sleep(3000);
        //    WorkspaceManagerMenuOptionsPage.DeleteSelectedWorkspace();
        //    Thread.Sleep(4000);
        //    WorkspaceManagerMenuOptionsPage.DeleteWorkspaceFromWorkspaceManager();
        //    Thread.Sleep(4000);
        //    GenericMethod.SaveScreenShot(driver, "PerformDeleteMenuOperationsOnAccountWorkspace");
        //}

    }
}
