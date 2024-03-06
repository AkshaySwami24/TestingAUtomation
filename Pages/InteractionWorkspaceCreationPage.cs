using IronXL;
using NUnit.Framework;
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
    public class InteractionWorkspaceCreationPage : BasePage
    {
        public static readonly By workspaceName_Locator = By.XPath("//input[@data-placeholder='Workspace Name']");
        public static readonly By Baseobject_options_Locator = By.XPath("//span[@class='mat-option-text'][contains(text(),'Interaction')]");
        public static readonly By selectBaseobjectCTV_Locator = By.XPath("//span[@class='mat-option-text'][contains(text(),'Interaction')]");
        public static readonly By SelectWorkspace_Locator = By.XPath("//td[contains(text(),' Talisma_Automation_InteractionWorkspace ')]");


        public PageElement workspaceName;
        public PageElement Baseobject_options;
        public PageElement selectBaseobjectCTV;
        private PageElement SelectWorkspace;

        public InteractionWorkspaceCreationPage(IWebDriver driver) : base(driver)
        {
            workspaceName = new PageElement(driver, workspaceName_Locator);
            Baseobject_options = new PageElement(driver, Baseobject_options_Locator);
            selectBaseobjectCTV = new PageElement(driver, selectBaseobjectCTV_Locator);
            SelectWorkspace = new PageElement(driver, SelectWorkspace_Locator);
        }

        public void EnterWorkspaceName()
        {
            WorkBook wbook = WorkBook.Load("C:\\Users\\AkshaySwami\\source\\repos\\Talisma_TestUI\\Talisma_Automation_Excel\\Automation_Excel.xlsx");
            //WorkBook wbook = WorkBook.Load(".\\Talisma_TestUI\\Talisma_Automation_Excel\\Automation_Excel.xlsx");
            WorkSheet wsheet = wbook.GetWorkSheet("WorkspaceName");
            string NameWorkspace = wsheet["A6"].StringValue;
            workspaceName.EnterData(NameWorkspace);
        }
        public void selectBaseObjectOption()
        {
            Baseobject_options.Click();

        }
        public void selectObjectfromOption()
        {
            //Thread.Sleep(5000);
            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //js.ExecuteScript("window.scrollBy(0,3000)");
            selectBaseobjectCTV.Click();
        }
        public void SelectWOrkspace()
        {
            SelectWorkspace.WaitAndGetElement().Click();
        }

       

    }
    
}
