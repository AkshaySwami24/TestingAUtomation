using AngleSharp.Dom;
using AngleSharp.Dom.Events;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Talisma_Automation.Utils;


namespace Talisma_Automation.Pages
{
    public class QuickAccessSettingsPage : BasePage
    {

        public static readonly By Quick_SettingTools_Locator = By.XPath("//span[@class='nav-settings-tool']");
        public static readonly By WorkspaceManager_Locator = By.XPath("//li[*='Workspace Manager']");
  

        public PageElement Quick_SettingTools;
        public PageElement WorkspaceManager;
       
       

        public QuickAccessSettingsPage(IWebDriver driver) : base(driver)
        {

            Quick_SettingTools = new PageElement(driver, Quick_SettingTools_Locator);
            WorkspaceManager = new PageElement(driver, WorkspaceManager_Locator);
  
        }

        public void navigatetoSessting()
        {
            Quick_SettingTools.WaitAndGetElement();
            Actions actions = new Actions(driver);
            actions.MoveToElement((IWebElement)Quick_SettingTools.WaitAndGetElement()).Click().Build().Perform();
           
        }

        public void clickOnWorkspaceManager()
        {
            WorkspaceManager.Click();
        } 
    }
  
}

