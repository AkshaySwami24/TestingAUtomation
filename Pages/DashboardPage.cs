using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Talisma_Automation.Utils;

namespace Talisma_Automation.Pages
{
    public class DashboardPage : BasePage
    {

        public static readonly By Dashboard_Option_Locator = By.CssSelector("[title='01-Dashboard']");
        public static readonly By Menu_Button_Locator = By.Id("wsmain");
        
        public PageElement Dashboard_Option;
        public PageElement Menu_Button;
        
        public DashboardPage(IWebDriver driver) : base(driver)
        {
            Dashboard_Option = new PageElement(driver, Dashboard_Option_Locator);
            Menu_Button = new PageElement(driver, Menu_Button_Locator);
        }


        public void SelectDashboardFromMenu(string username, string password)
        {
            Menu_Button.Click();
            Dashboard_Option.Click();
        }
    }
}
