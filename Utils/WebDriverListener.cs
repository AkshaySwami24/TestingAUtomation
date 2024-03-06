using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.Extensions;

namespace Talisma_Automation.Utils
{
    public class WebDriverListener : EventFiringWebDriver
    {
        private readonly IWebDriver driver;
        private readonly Logger logger;

        public WebDriverListener(IWebDriver parentDriver, Logger logger) : base(parentDriver)
        {
            driver = parentDriver;
            this.logger = logger;
            Navigating += WebDriverListener_Navigating;
            Navigated += WebDriverListener_Navigated;
        }

        private void WebDriverListener_Navigating(object sender,
            WebDriverNavigationEventArgs e)
        {
            LogMessage($"Navigating to {e.Url}");
        }

       
        private void WebDriverListener_Navigated(object sender,
            WebDriverNavigationEventArgs e)
        {
            LogMessage($"Navigated to [{e.Driver.Title}]({e.Url})");
        }

        private void LogMessage(string text)
        {
            logger.Info(text);
        }
    }
}