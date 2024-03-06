using AngleSharp.Common;
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
    public class AccountWorkspaceMenuOperationsPage : BasePage
    {

        public static readonly By WorkspaceTitle_Locator = By.XPath("//span[@title='Talisma_Automation_AccountWorkspace']");
        public static readonly By RenameWorkspaceTo_Locator = By.XPath("//div[@class='mat-form-field-infix ng-tns-c40-4']");
        public static readonly By ClearRenameWorkspaceTo_Locator = By.XPath("//div[@class='mat-form-field-infix ng-tns-c40-4']");


        public PageElement WorkspaceTitle;
        public PageElement RenameWorkspaceTo;
        public PageElement ClearRenameWorkspaceTo;  

        public AccountWorkspaceMenuOperationsPage(IWebDriver driver) : base(driver)
        {
            WorkspaceTitle = new PageElement(driver, WorkspaceTitle_Locator);
            RenameWorkspaceTo = new PageElement(driver, RenameWorkspaceTo_Locator);
            ClearRenameWorkspaceTo = new PageElement(driver, ClearRenameWorkspaceTo_Locator);
        }
        public void SelectTitleofWorkspace()
        {
            WorkspaceTitle.Click();
        }
        public void RenameWorkspace()
        {

            // object value = driver.SwitchTo().Window('string windowName').WindowHandles().Click();
            //value= value.ToString();

            RenameWorkspaceTo.Click();  
            
                //EnterData("Renamed_Talisma_Automation_AccountWorkspace");
        }
        public void ClearValueFromRenameWorkspace()
        {

            ClearRenameWorkspaceTo.Clear();

        }

    }
}
