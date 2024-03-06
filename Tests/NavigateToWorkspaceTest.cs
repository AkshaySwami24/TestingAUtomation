using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Talisma_Automation.Pages;

namespace Talisma_Automation.Tests
{

    [TestFixture]
   //[Parallelizable(ParallelScope.Fixtures)]

    public class NavigateToWorkspaceTest : BasePageTest
    {
        private NavigateToWorkspacePage workspace;
        private LoginPage LoginPage;
        private DashboardPage DashboardPage;

        [SetUp]
        public void SetupFixture()
        {
            workspace = new NavigateToWorkspacePage(driver);
            LoginPage = new LoginPage(driver);
            DashboardPage = new DashboardPage(driver);
        }

        [Test]
        public void navigatetoleftnavworkspace()
        {
            LoginPage.LoginToApp("talismaadmin", "talisma1");
            Thread.Sleep(2000);
            if (LoginPage.IsAlertPresent())
            {
                LoginPage.CloseAlert();
            }
            Thread.Sleep(2000);
            workspace.navigatetoworkspace();
            Thread.Sleep(2000);
            workspace.searchWorkspace();
            Thread.Sleep(5000);
            workspace.openWorkspaceTableView();
            Thread.Sleep(5000);
            workspace.createnewinteraction();

            workspace.ClickonNewInteraction();

        }

    }
}