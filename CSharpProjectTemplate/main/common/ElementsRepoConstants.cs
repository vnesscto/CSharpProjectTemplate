using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProjectTemplate.main.utils
{
    // Test Project example page.
    class ElementsRepoConstants
    {
        //Login Page.
        public const String TP_USER_NAME_INPUT_XPATH = "//input[@id='name']";
        public const String TP_PASSWORD_INPUT_XPATH = "//input[@id='password']";
        public const String TP_LOGIN_BUTTON_XPATH = "//button[@id='login']";
        public const String TP_LOGOUT_BUTTON_XPATH = "//button[@id='logout']";

        //Form Page.
        public const String TP_COUNTRY_DROPDOWN_XPATH = "//select[@id='country']";
        public const String TP_ADDRESS_INPUT_XPATH = "//input[@id='address']";
        public const String TP_EMAIL_INPUT_XPATH = "//input[@id='email']";
        public const String TP_PHONE_INPUT_XPATH = "//input[@id='phone']";
        public const String TP_SAVE_BUTTON_XPATH = "//button[@id='save']";
        public const String TP_CONFIRM_MESSAGE_XPATH = "//span[@class='tp-saved']";

        //Windows Calculator.
        public const String FIRST_NUMBER = "Error accrued: ";
        public const String LOG_ERROR_MESSAGE = "Six";
        public const String SECOND_NUMBER = "Five";
        public const String MATH_SIGN_PLUS = "Plus";
        public const String MATH_SIGN_EQUALS = "Equals";
        public const String RESULT_XPATH = "//*[@AutomationId='CalculatorResults']";
        public const String CLEAR_BUTTON_XPATH = "//*[@AutomationId='clearButton']";

        //EriBank
        public const String ERI_USERNAME_XPATH = "//*[@id='usernameTextField']";
        public const String ERI_PASSWORD_XPATH = "//*[@id='passwordTextField']";
        public const String ERI_LOGIN_BUTTON_XPATH = "//*[@text='Login']";
        public const String ERI_LOGOUT_BUTTON_XPATH = "//*[@text='Logout']";

    }
}
