using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Talisma_Automation.Utils;

namespace Talisma_Automation.Pages
{
    public class LoginPage : BasePage
    {

        public static readonly By UserName_TextBox_Locator = By.Id("username");
        public static readonly By Password_TextBox_Locator = By.Id("password");
        public static readonly By Login_Button_Locator = By.Id("Submit");

        public PageElement UserName_TextBox;
        public PageElement Password_TextBox;
        public PageElement Login_Button;

        public LoginPage (IWebDriver driver) : base(driver)
        {
            UserName_TextBox = new PageElement(driver, UserName_TextBox_Locator);
            Password_TextBox = new PageElement(driver, Password_TextBox_Locator);
            Login_Button = new PageElement(driver, Login_Button_Locator);
        }


        public void LoginToApp(string username, string password)
        {
            UserName_TextBox.EnterData(username);
            Password_TextBox.EnterData(password);
            Login_Button.Click();
        }

    }
}
