using CSharpProjectTemplate.main.utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProjectTemplate.main.bussinessProcess
{
    /**
    * This is an example business processes for Test Project demo website tests.
    */
    class TestProjectExampleWebSite
    {
        /**
     * This step executes CommonMethods class methods and steps for a login process to test project demo website.
     *
     * @param driver used to manage timeouts.
     * @return Boolean value  for validation.
     */
        //@Step("Login process")
    public static Boolean loginToTestProject(IWebDriver driver)
        {
            ManagePages.testProjectLoginPage.goToURL("https://example.testproject.io/web/");
            CommonMethods.sendText(ManagePages.testProjectLoginPage.getUserNameElement(), Constants.USER_NAME);
            CommonMethods.sendText(ManagePages.testProjectLoginPage.getPasswordElement(), Constants.PASSWORD);
            CommonMethods.click(ManagePages.testProjectLoginPage.getLoginBtnElement());

            new WaitForHelper(driver).presenceOfTheElement(ManagePages.testProjectLoginPage.getLogOutBtnElement());
            return ManagePages.testProjectLoginPage.getLogOutBtnElement().Displayed;
        }

        /**
         * This step executes CommonMethods class methods and steps for a form fill process on test project demo website.
         *
         * @param driver used to manage timeouts.
         * @return String result for validation.
         */
        //@Step("Fill Test Project example form")
    public static String fillTestProjectForm(IWebDriver driver)
        {
            CommonMethods.selectDropDownByText(ManagePages.testProjectFormPage.getCountries(), Constants.COUNTRY_TO_SELECT);
            CommonMethods.sendText(ManagePages.testProjectFormPage.getAddressElement(), Constants.ADDRESS);
            CommonMethods.sendText(ManagePages.testProjectFormPage.getEmailElement(), Constants.EMAIL);
            CommonMethods.sendText(ManagePages.testProjectFormPage.getPhoneElement(), Constants.PHONE_NUMBER);
            CommonMethods.click(ManagePages.testProjectFormPage.getSaveButtonElement());

            new WaitForHelper(driver).presenceOfTheElement(ManagePages.testProjectFormPage.getConfirmMessageElement());
            return ManagePages.testProjectFormPage.getConfirmMessageElement().Text;
        }
    }
}
