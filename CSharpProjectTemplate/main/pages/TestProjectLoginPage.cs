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
    class TestProjectLoginPage : BasePage
    {

        public TestProjectLoginPage(IWebDriver driver) :base(driver)
        {
            this.driver = driver;
        }

        // Elements Locators.
        private By username = By.XPath(ElementsRepoConstants.TP_USER_NAME_INPUT_XPATH);
        private By password = By.XPath(ElementsRepoConstants.TP_PASSWORD_INPUT_XPATH);
        private By loginButton = By.XPath(ElementsRepoConstants.TP_LOGIN_BUTTON_XPATH);
        private By logoutButton = By.XPath(ElementsRepoConstants.TP_LOGOUT_BUTTON_XPATH);

        /**
         * This method return the username input element.
         *
         * @return WebElement.
         */
        public IWebElement getUserNameElement()
        {
            return driver.FindElement(username);
        }

        /**
         * This method return the password input element.
         *
         * @return WebElement.
         */
        public IWebElement getPasswordElement()
        {
            return driver.FindElement(password);
        }

        /**
         * This method return the login button element.
         *
         * @return WebElement.
         */
        public IWebElement getLoginBtnElement()
        {
            return driver.FindElement(loginButton);
        }

        /**
         * This method return the logout button element.
         *
         * @return WebElement.
         */
        public IWebElement getLogOutBtnElement()
        {
            return driver.FindElement(logoutButton);
        }

    }
}
