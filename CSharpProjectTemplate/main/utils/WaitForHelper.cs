using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;


namespace CSharpProjectTemplate.main.utils
{
   /**
    * Helper class for managing driver wait.
    */
    class WaitForHelper
    {
        public IWebDriver driver;

        public WaitForHelper(IWebDriver driver)
        {
            this.driver = driver;
        }

        /**
         * This method sets the implicitlyWait timeout of the driver to a default value is saved in the Constants class.
         */
        public void implicitWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Constants.IMPLICIT_WAIT_TIME);
        }

        /**
         * This method waits for received element to be clickable.
         * Wait time value is saved in the Constants class.
         *
         * @param element to be checked if clickable.
         * @return the given element.
         */
        public IWebElement presenceOfTheElement(IWebElement element)
        {
            IWebElement firstResult = new WebDriverWait(driver, TimeSpan.FromSeconds(Constants.EXPLICIT_WAIT_TIME))
                .Until(ExpectedConditions.ElementToBeClickable(element));

            return firstResult;
        }
    }
}
