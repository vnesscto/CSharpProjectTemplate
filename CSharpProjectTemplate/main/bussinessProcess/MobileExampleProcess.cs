using CSharpProjectTemplate.main.utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProjectTemplate.main.bussinessProcess
{
    /**
     * This is an example business process for mobile login test.
     */
    class MobileExampleProcess
    {
        /**
    * This step executes CommonMethods steps and actions to achieve Mobile login test.
    *
    * @param driver given to manage timeouts.
    * @return Boolean value for validation.
    */
        //@Step("Login process")
    public static Boolean loginToEriBank(IWebDriver driver)
        {
            CommonMethods.sendText(ManagePages.mobileLoginPage.getUserNameElement(), "company");
            CommonMethods.sendText(ManagePages.mobileLoginPage.getPasswordElement(), "company");
            CommonMethods.click(ManagePages.mobileLoginPage.getLoginButton());

            new WaitForHelper(driver).presenceOfTheElement(ManagePages.mobileLoginPage.getLogoutButton());
            return ManagePages.mobileLoginPage.getLogoutButton().Displayed;
        }
    }
}
