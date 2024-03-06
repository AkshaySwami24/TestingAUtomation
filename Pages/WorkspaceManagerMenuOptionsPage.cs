using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talisma_Automation.Pages;
using Talisma_Automation.Utils;

namespace Talisma_TestUI.Pages
{
    public class WorkspaceManagerMenuOptionsPage : BasePage
    {
        public static readonly By ViewOption_Locator = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/mat-dialog-container[1]/app-workspace-list[1]/div[3]/div[1]/button[1]");
        public static readonly By NewWorkspace_Locator = By.XPath("//button[*='New']");
        public static readonly By EditWorkspace_Locator = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/mat-dialog-container[1]/app-workspace-list[1]/div[3]/div[3]/button[1]");
        public static readonly By RenameWorkspace_Locator = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/mat-dialog-container[1]/app-workspace-list[1]/div[3]/div[4]/button[1]");
        public static readonly By DeleteWorkspace_Locator = By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/mat-dialog-container[1]/app-workspace-list[1]/div[3]/div[5]/button[1]");
        public static readonly By ConfirmToDeleteWorkspaceTo_Locator = By.XPath("//span[contains(text(),'Yes')]");


        public PageElement ViewOption;
        public PageElement NewWorkspace;
        public PageElement EditWorkspace;
        public PageElement RenameWorkspace;
        public PageElement DeleteWorkspace;
        public PageElement ConfirmToDeleteWorkspaceTo;

        public WorkspaceManagerMenuOptionsPage(IWebDriver driver) : base(driver)
        {
            ViewOption = new PageElement(driver, ViewOption_Locator);
            NewWorkspace = new PageElement(driver, NewWorkspace_Locator);
            EditWorkspace = new PageElement(driver, EditWorkspace_Locator);
            RenameWorkspace = new PageElement(driver, RenameWorkspace_Locator);
            DeleteWorkspace = new PageElement(driver, DeleteWorkspace_Locator);
            ConfirmToDeleteWorkspaceTo = new PageElement(driver, ConfirmToDeleteWorkspaceTo_Locator);
        }

        public void ViewWorkspace()
        {
            ViewOption.WaitAndGetElement().Click();
        }
        public void newWorkspaceManager()
        {
            NewWorkspace.WaitAndGetElement().Click();
        }
        public void EditWorkspaceToModify()
        {
            EditWorkspace.WaitAndGetElement().Click();
        }
        public void RenameExistingWorkspace()
        {
            RenameWorkspace.Click();
        }
        public void DeleteSelectedWorkspace()
        {
            DeleteWorkspace.Click();
        }
        public void DeleteWorkspaceFromWorkspaceManager()
        {

            ConfirmToDeleteWorkspaceTo.Click();
        }

    }
}
