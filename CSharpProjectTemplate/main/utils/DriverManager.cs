using log4net.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace CSharpProjectTemplate.main.utils
{
    /**
    * This method calling driver initialize methods using given platform.
    */
    class DriverManager
    {
        protected static IWebDriver driver;

        /**
         * This method calling driver initialize methods using given platform.
         */
        public void initDriver()
        {
            switch (Constants.PLATFORM.ToLower())
            {
                case "web": {
                        Logger.info("Initializing Web Driver");
                        try
                        {
                            setWebDriver();
                            driver.Manage().Window.Maximize();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.StackTrace);
                            Logger.error("Web Driver Failure", e);
                        }
                        break;
                    }
                case "desktop": {
                        Logger.info("Initializing Windows Driver");
                        try
                        {
                            setWindowsDriver();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.StackTrace);
                            Logger.error("Windows Driver Failure", e);
                        }
                        break;
                    }
                case "mobile": {
                        Logger.info("Initializing Appium Driver");
                        try
                        {
                            setAppiumDriver();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.StackTrace);
                            Logger.error("Android Driver Failure", e);
                        }
                        break;
                    }
            }

        }


        /**
         * This method initialize web driver using given browser type.
         */
        private void setWebDriver()
        {
            switch (Constants.BROWSER_TYPE.ToLower())
            {
                case "chrome": {
                        Logger.info("Found chrome as Browser");
                        new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                        driver = new ChromeDriver();
                        break;
                    }
                case "edge": {
                        new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                        driver = new EdgeDriver();
                        break;
                    }
                case "firefox": {
                        Logger.info("Found firefox as Browser");
                        new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                        driver = new FirefoxDriver();
                        break;
                    }
                case "ie": {
                        Logger.info("Found IE as Browser");
                        new WebDriverManager.DriverManager().SetUpDriver(new InternetExplorerConfig());
                        driver = new InternetExplorerDriver();
                        break;
                    }
                case "opera": {
                        Logger.info("Found opera as Browser");
                        new WebDriverManager.DriverManager().SetUpDriver(new OperaConfig());
                        driver = new OperaDriver();
                        break;
                    }
                default: throw new Exception("Unsupported Browser Type");
            }
        }

        /**
         * This method initialize the driver as WindowsDriver.
         *
         * @throws MalformedURLException Thrown to indicate that a malformed URL has occurred.
         */
        private void setWindowsDriver()
        {
            DesiredCapabilities dc = new DesiredCapabilities();
            dc.SetCapability("app", Constants.APP_PATH);
            driver = new RemoteWebDriver(new Uri(Constants.IP_PORT), dc);
        }

        /**
         * This method initialize the driver as Appium(AndroidDriver).
         *
         * @throws MalformedURLException Thrown to indicate that a malformed URL has occurred.
         */

        private void setAppiumDriver()
        {
            DesiredCapabilities dc = new DesiredCapabilities();
            dc.SetCapability("reportDirectory", Constants.REPORT_DIRECTORY);
            dc.SetCapability("reportFormat", Constants.REPORT_FORMAT);
            dc.SetCapability("testName", Constants.TEST_NAME);
            dc.SetCapability(MobileCapabilityType.Udid, Constants.UD_ID);
            dc.SetCapability(AndroidMobileCapabilityType.AppPackage, Constants.APP_PACKAGE);
            dc.SetCapability(AndroidMobileCapabilityType.AppActivity, Constants.APP_ACTIVITY);
            driver = new RemoteWebDriver(new Uri(Constants.DRIVER_URL), dc);
        }


        /**
         * This method returns the current driver.
         *
         * @return the driver after initialization
         */
        public IWebDriver getDriver()
    {
        return driver;
    }

    }
}
