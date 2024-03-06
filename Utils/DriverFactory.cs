using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Talisma_Automation.Utils
{
    public class DriverFactory
    {
        
        public IWebDriver GetWebDriver(string browser)
        {
         
            IWebDriver driver;
            var logger = new Logger("logger", InternalTraceLevel.Info, TextWriter.Null);
            switch (browser)
            {
                case "Edge":
                    //new DriverManager().SetUpDriver(new EdgeConfig());
                    new DriverManager().SetUpDriver(new ChromeConfig());
                    var chromeOptions = new ChromeOptions();
                    chromeOptions.AddAdditionalCapability("useAutomationExtension", false);
                    chromeOptions.AddExcludedArgument("enable-automation");
                    chromeOptions.AddArgument("--disable-save-password-bubble");
                    chromeOptions.AddArgument("ignore-certificate-errors");
                    chromeOptions.AddArgument("start-maximized");
                    var chromeDriver = new ChromeDriver(chromeOptions);
                    driver = chromeDriver;
                    //driver = new WebDriverListener(chromeDriver, logger);
                    break;
                default:
                    //new DriverManager().SetUpDriver(new EdgeConfig());
                    var options = new EdgeOptions();
                    // options.AddAdditionalCapability("profile.default_content_settings.popups", 0);
                    //options.AddAdditionalCapability("download.default_directory", TestUtils.downloadPath);
                    //options.AddAdditionalCapability("download.prompt_for_download", false);
                    // options.PageLoadStrategy = PageLoadStrategy.Normal;
                    //options.UseInPrivateBrowsing = true;
                    var edgeDriver = new EdgeDriver(@"C:\Users\AkshaySwami\OneDrive - Anthology Inc\doc\Drivers\");
                    driver = edgeDriver;
                    //driver = new WebDriverListener(edgeDriver, logger);
                    break;

                    
            }
            return driver;
        }
    }
}
