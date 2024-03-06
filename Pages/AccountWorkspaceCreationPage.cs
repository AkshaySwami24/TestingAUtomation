using IronXL;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Talisma_Automation.Pages;
using Talisma_Automation.Utils;

namespace Talisma_TestUI.Pages
{
    public class AccountWorkspaceCreationPage : BasePage
    {
    
        public static readonly By workspaceName_Locator = By.XPath("//input[@data-placeholder='Workspace Name']");
        public static readonly By BaseObject_Locator = By.XPath("//div[@class='mat-form-field-infix ng-tns-c40-5']");    // to validate the base object issue
       // public static readonly By Baseobject_options_Locator = By.XPath("//span[@class='mat-option-text'][contains(text(),'Interaction')]");
        public static readonly By Baseobject_options_Locator = By.XPath("//span[contains(text(),'Account')]");
        public static readonly By Addview_Locator = By.XPath("//span[@class='topnav-new smallIcon']");
        public static readonly By TalismaTableView_Locator = By.XPath("//button[contains(text(),'Talisma Table View')]"); ////button[contains(text(),'Talisma Table View')]
        public static readonly By Tableview_entycomponent_Locator = By.XPath("//span[@class='emptyComponent']");
        public static readonly By ConfigureTV_selectObject_Locator = By.Id("mat-select-value-3");
        //public static readonly By selectBaseobjectCTV_Locator = By.XPath("//span[@class='mat-option-text'][contains(text(),'Interaction')]");
        public static readonly By selectBaseobjectCTV_Locator = By.XPath("//span[@class='mat-option-text'][contains(text(),'Account')]");
        public static readonly By OK_Butoon_Tableview_Locator = By.XPath("/html[1]/body[1]/div[1]/div[6]/div[1]/mat-dialog-container[1]/app-tv-component[1]/div[2]/div[2]/div[1]/button[1]");
        public static readonly By Ok_button_workspaceCreationWizard_Locator = By.XPath("//body[@id='MainBody']/div[@class='cdk-overlay-container']/div[@class='cdk-global-overlay-wrapper']/div[@id='cdk-overlay-1']/mat-dialog-container[@id='mat-dialog-1']/app-workspace-design[@class='ng-star-inserted']/div[@class='mat-dialog-actions']/button[2]");
        public static readonly By SelectWorkspace_Locator = By.XPath("//td[contains(text(),'Talisma_Automation_AccountWorkspace')]");


        public PageElement workspaceName;
        public PageElement BaseObject;
        public PageElement Baseobject_options;
        public PageElement Addview;
        public PageElement TalismaTableView;
        public PageElement Tableview_entycomponent;
        public PageElement ConfigureTV_selectObject;
        public PageElement selectBaseobjectCTV;
        public PageElement OK_Butoon_Tableview;
        public PageElement Ok_button_workspaceCreationWizard;
        public PageElement SelectWorkspace;

        public AccountWorkspaceCreationPage(IWebDriver driver) : base(driver)
        {
            workspaceName = new PageElement(driver, workspaceName_Locator);
            BaseObject = new PageElement(driver, BaseObject_Locator);
            Baseobject_options = new PageElement(driver, Baseobject_options_Locator);
            Addview = new PageElement(driver, Addview_Locator);
            TalismaTableView = new PageElement(driver, TalismaTableView_Locator);
            Tableview_entycomponent = new PageElement(driver, Tableview_entycomponent_Locator);
            ConfigureTV_selectObject = new PageElement(driver, ConfigureTV_selectObject_Locator);
            selectBaseobjectCTV = new PageElement(driver, selectBaseobjectCTV_Locator);
            OK_Butoon_Tableview = new PageElement(driver, OK_Butoon_Tableview_Locator);
            Ok_button_workspaceCreationWizard = new PageElement(driver, Ok_button_workspaceCreationWizard_Locator);
            SelectWorkspace = new PageElement(driver, SelectWorkspace_Locator);
        }
        public void EnterWorkspaceName()
        {
            WorkBook wbook = WorkBook.Load("C:\\Users\\AkshaySwami\\source\\repos\\Talisma_TestUI\\Talisma_Automation_Excel\\Automation_Excel.xlsx");
            WorkSheet wsheet = wbook.GetWorkSheet("WorkspaceName");
            string NameWorkspace = wsheet["A3"].StringValue;
            workspaceName.EnterData(NameWorkspace);
        }

        public void selectBaseObject()
        {
            BaseObject.Click();

        }
        public void selectBaseObjectOption()
        {
            Baseobject_options.Click();

        }
        public void AddviewToWorkspacemanager()
        {
            Addview.Click();

        }
        public void AddTableviewToWorkspacemanager()
        {
            TalismaTableView.Click();

        }
        public void ClickonTableviewtoconfigure()
        {
            Tableview_entycomponent.Click();

        }
        public void selectBaseObjecttoConfigureTV()
        {
            ConfigureTV_selectObject.Click();

        }
        public void selectObjectfromOption()
        {
            Thread.Sleep(5000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,3000)");
            selectBaseobjectCTV.Click();

        }
        public void ClickOKonceTableViewisconfigured()
        {
            OK_Butoon_Tableview.WaitAndGetElement().Click();

        }
        public void ClickOKtoCreateWorkspace()
        {
            Ok_button_workspaceCreationWizard.WaitAndGetElement().Click();

        }
        public void SelectWOrkspace()
        {
            SelectWorkspace.WaitAndGetElement().Click();
        }

    }
}
