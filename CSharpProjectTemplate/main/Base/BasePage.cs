using CSharpProjectTemplate.main.utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProjectTemplate.main.Base
{
    /*
    Base Page class, Page Object classes should extend this class.
 */
    class BasePage
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        /**
         * This method navigates to the given URL.
         *
         * @param url given URL to navigate to.
         */
        public void goToURL(String url)
        {
            driver.Navigate().GoToUrl(url);
        }

        /**
         * This method using WaitForHelper class to set implicit wait time.
         */
        public void waitForTime()
        {
            new WaitForHelper(driver).implicitWait();
        }

        /**
         * This method waits conditionally for the given element to be present
         *
         * @param element given element to wait for.
         */
        public void waitForElementToAppear(IWebElement element)
        {
            new WaitForHelper(driver).presenceOfTheElement(element);
        }
    }
}
