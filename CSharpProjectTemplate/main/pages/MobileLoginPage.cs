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
    class MobileLoginPage:BasePage
    {
        public MobileLoginPage(IWebDriver driver):base(driver)
        {
            this.driver = driver;
        }

        // Elements Locators.
        private By username = By.XPath(ElementsRepoConstants.ERI_USERNAME_XPATH);
        private By password = By.XPath(ElementsRepoConstants.ERI_PASSWORD_XPATH);
        private By loginButton = By.XPath(ElementsRepoConstants.ERI_LOGIN_BUTTON_XPATH);
        private By logoutButton = By.XPath(ElementsRepoConstants.ERI_LOGOUT_BUTTON_XPATH);

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
        public IWebElement getLoginButton()
        {
            return driver.FindElement(loginButton);
        }

        /**
         * This method return the logout button element.
         *
         * @return WebElement.
         */
        public IWebElement getLogoutButton()
        {
            return driver.FindElement(logoutButton);
        }

    }
}
