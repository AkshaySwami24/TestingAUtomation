using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using EC = SeleniumExtras.WaitHelpers.ExpectedConditions;



namespace Talisma_Automation.Utils
{
    public class PageElement
    {
        public long TIME_OUT = 10;
        public IWebDriver driver;
        public By locator;

        public PageElement(IWebDriver driver, By locator)
        {
            this.driver = driver;
            this.locator = locator;
        }

        public By GetLocator()
        {
            return locator;
        }

        public IWebElement GetWebElement()
        {
            return driver.FindElement(locator);
        }

        public void Click()
        {
            WaitAndGetElement().Click();
        }

        public void Clear()
        {
            WaitAndGetElement().Clear();
        }

        public void EnterData(string text) => GetWebElement().SendKeys(text);

        public string GetText()
        {
            return WaitAndGetElement().Text;
        }


        public IWebElement WaitAndGetElement()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(TIME_OUT));
            return wait.Until(EC.ElementExists(locator));
        }

        public bool IsElementDisplayed() {
            try
            {
                WaitAndGetElement();
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Element is not visible");
            }
        }

        public void ClickOnClickableElement() {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(TIME_OUT));
            wait.Until(EC.ElementToBeClickable(locator)).Click(); 
        }

        internal void SelectByValue()
        {
            throw new NotImplementedException();
        }
    }
}

