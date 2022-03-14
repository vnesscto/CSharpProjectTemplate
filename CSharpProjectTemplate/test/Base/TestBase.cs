using CSharpProjectTemplate.main.utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProjectTemplate.test.Base
{
    /**
    * Base class for over test classes.
    * Test classes should extend this class.
    */
    class TestBase:DriverManager
    {
        /**
        * This is a setup method that runs before each test class and used to call initDriver method of DriverManager.
        */
        [SetUp]
        public void setUp()
        {
            Logger.info("Setting up driver");
            initDriver();
            switch (Constants.PLATFORM.ToLower())
            {
                case "web":
                    ManagePages.initWebPages();
                    Logger.info("Initializing web pages");
                    break;
                case "desktop":
                    ManagePages.initDesktopPages();
                    Logger.info("Initializing desktop pages");
                    break;
                case "mobile":
                    ManagePages.initMobilePages();
                    Logger.info("Initializing mobile pages");
                    break;
            }
            new WaitForHelper(driver).implicitWait();
        }

        /**
         * This method is a teardown method used to quit driver after each test class.
         */
        [TearDown]
        public void tearDown()
        {
            Logger.info("Closing driver");
            //driver.Close();
            driver.Quit();
        }
    }
}
