using AngleSharp.Dom;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Talisma_Automation.Pages;
using Talisma_Automation.Utils;

namespace Talisma_Automation.Pages
{
    public class NavigateToWorkspacePage :BasePage 
    {
        
        public static readonly By Leftnav_workspace_Locator = By.Id("wsmain");
        public static readonly By SearchforWorkspace_Locator = By.Id("searchtb");
        public static readonly By OpenWorkspace_Locator = By.Id("ws-437");  //--437 for the srv1 workspace   //li[@title='New Interaction (CTRL+ALT+N)']
        public static readonly By newInteraction_Locator = By.XPath("//*[@class='menu-new menu-correction']");
        public static readonly By ClickNewInteraction_Locator = By.XPath("//li[@title='New Interaction (CTRL+ALT+N)']");

        public PageElement Leftnav_workspace;
        public PageElement SearchforWorkspace;
        public PageElement OpenWorkspace;
        public PageElement newInteraction;
        public PageElement ClickNewInteraction;

        public NavigateToWorkspacePage (IWebDriver driver) : base(driver)
        {
            Leftnav_workspace = new PageElement(driver, Leftnav_workspace_Locator);
            SearchforWorkspace= new PageElement(driver, SearchforWorkspace_Locator);
           OpenWorkspace = new PageElement(driver, OpenWorkspace_Locator);
            newInteraction = new PageElement(driver, newInteraction_Locator);
            ClickNewInteraction = new PageElement(driver, ClickNewInteraction_Locator);
        }

        public void navigatetoworkspace()
        {
            Leftnav_workspace.WaitAndGetElement();
            Actions actions = new Actions(driver);
            actions.MoveToElement((IWebElement)Leftnav_workspace.WaitAndGetElement()).Click().Build().Perform();
            Thread.Sleep(3300);
        }

        public void searchWorkspace()
        {
           
            SearchforWorkspace.WaitAndGetElement();
            SearchforWorkspace.EnterData("Interaction");
            Thread.Sleep(5000);
            
        }

       // public void openWorkspaceTableView(IWebDriver driver, IWebElement element)
       public void openWorkspaceTableView()
         {
           
            OpenWorkspace.WaitAndGetElement();
           
            OpenWorkspace.ClickOnClickableElement();
           

        }

        public void createnewinteraction()
        {
           newInteraction.Click();
            Thread.Sleep(5000);
  
        }

        public void ClickonNewInteraction()
        {
            ClickNewInteraction.Click();
            Thread.Sleep(5000);

        }
    }
}
