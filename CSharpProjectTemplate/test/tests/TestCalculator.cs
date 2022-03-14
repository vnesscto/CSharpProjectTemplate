using CSharpProjectTemplate.main.bussinessProcess;
using CSharpProjectTemplate.main.utils;
using CSharpProjectTemplate.test.Base;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProjectTemplate.test.tests
{
    /**
    * This is Windows Applications example test.
     */
    [AllureNUnit]
    class TestCalculator :TestBase
    {
        /**
        * This is an addition example test using windows calculator.
         */
        [Test,Description("Addition test.")]
        public void additionTest()
        {
            Logger.startTestCase("additionTest");
            String result = CalculatorExample.performAddition();
            Assert.AreEqual(result, Constants.EXPECTED_CALC_RESULT);
            Logger.endTestCase("additionTest");
        }
    }
}
