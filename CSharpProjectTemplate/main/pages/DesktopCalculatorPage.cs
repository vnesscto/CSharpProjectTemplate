using CSharpProjectTemplate.main.Base;
using CSharpProjectTemplate.main.utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProjectTemplate.main.pages
{

    /**
     * This is an Example for Page Object class.
     */
    class DesktopCalculatorPage :BasePage
    {

        public DesktopCalculatorPage(IWebDriver driver):base(driver)
        {
            this.driver = driver;
        }

        /**
         * This method receives number to locate the calculator number element.
         *
         * @param number used as a locator.
         * @return the number WebElement.
         */
        public IWebElement getNumber(String number)
        {
            return driver.FindElement(By.Name(number));
        }

        /**
         * This method receives mathematical sign to locate the calculator sign element.
         *
         * @param sign used as a locator
         * @return the sign WebElement.
         */
        public IWebElement getMathSign(String sign)
        {
            return driver.FindElement(By.Name(sign));
        }

        /**
         * This method used to locate the result and return the result.
         *
         * @return String of the displayed result.
         */
        public String getResult()
        {
            return driver.FindElement(By.XPath(ElementsRepoConstants.RESULT_XPATH))
                    .Text.Replace("Display is:", "").Trim();
        }

        /**
         * This method used to locate the calculator clear option.
         *
         * @return the clear WebElement
         */
        public IWebElement getClear()
        {
            return driver.FindElement(By.XPath(ElementsRepoConstants.CLEAR_BUTTON_XPATH));
        }
    }
}
