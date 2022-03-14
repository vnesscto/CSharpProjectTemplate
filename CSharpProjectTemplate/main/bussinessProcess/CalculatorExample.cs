using CSharpProjectTemplate.main.utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProjectTemplate.main.bussinessProcess
{
    /**
     * This is an example business process for calculator addition test.
     */
    class CalculatorExample
    {
        /**
 * This Step executes CommonMethods class methods and steps to achieve addition action of the calculator app.
 *
 * @return String of the addition result for validation.
 */
        //@Step("Addition between two numbers example")
        public static String performAddition()
        {
            CommonMethods.click(ManagePages.desktopCalculatorPage.getNumber(ElementsRepoConstants.FIRST_NUMBER));
            CommonMethods.click(ManagePages.desktopCalculatorPage.getMathSign(ElementsRepoConstants.MATH_SIGN_PLUS));
            CommonMethods.click(ManagePages.desktopCalculatorPage.getNumber(ElementsRepoConstants.SECOND_NUMBER));
            CommonMethods.click(ManagePages.desktopCalculatorPage.getNumber(ElementsRepoConstants.MATH_SIGN_EQUALS));
            return ManagePages.desktopCalculatorPage.getResult();
        }
    }
}
