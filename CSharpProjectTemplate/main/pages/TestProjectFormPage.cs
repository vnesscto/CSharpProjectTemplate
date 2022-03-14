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
    class TestProjectFormPage:BasePage
    {
        public TestProjectFormPage(IWebDriver driver):base(driver)
        {
            this.driver = driver;
        }

        // Elements Locators.
        private By countries = By.XPath(ElementsRepoConstants.TP_COUNTRY_DROPDOWN_XPATH);
        private By address = By.XPath(ElementsRepoConstants.TP_ADDRESS_INPUT_XPATH);
        private By email = By.XPath(ElementsRepoConstants.TP_EMAIL_INPUT_XPATH);
        private By phone = By.XPath(ElementsRepoConstants.TP_PHONE_INPUT_XPATH);
        private By saveButton = By.XPath(ElementsRepoConstants.TP_SAVE_BUTTON_XPATH);
        private By confirmMessage = By.XPath(ElementsRepoConstants.TP_CONFIRM_MESSAGE_XPATH);


        /**
         * This method return the country input element.
         *
         * @return WebElement
         */
        public IWebElement getCountries()
        {
            return driver.FindElement(countries);
        }

        /**
         * This method return the address input element.
         *
         * @return WebElement
         */
        public IWebElement getAddressElement()
        {
            return driver.FindElement(address);
        }

        /**
         * This method return the email input element.
         *
         * @return WebElement
         */
        public IWebElement getEmailElement()
        {
            return driver.FindElement(email);
        }

        /**
         * This method return the phone input element.
         *
         * @return WebElement
         */
        public IWebElement getPhoneElement()
        {
            return driver.FindElement(phone);
        }

        /**
         * This method return the saveButton button element.
         *
         * @return WebElement
         */
        public IWebElement getSaveButtonElement()
        {
            return driver.FindElement(saveButton);
        }

        /**
         * This method return the confirmMessage element.
         *
         * @return WebElement
         */
        public IWebElement getConfirmMessageElement()
        {
            return driver.FindElement(confirmMessage);
        }
    }
}
