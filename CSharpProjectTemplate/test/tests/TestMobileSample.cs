using CSharpProjectTemplate.main.bussinessProcess;
using CSharpProjectTemplate.main.utils;
using CSharpProjectTemplate.test.Base;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProjectTemplate.test.tests
{
    class TestMobileSample:TestBase
    {

        /**
         * This is a login test to EriBank Mobile app(Android).
         */
        [Test, Description("Verify login to eri bank app")]
        public void eriLogin()
        {
            Logger.startTestCase("eri login");
            Boolean result = MobileExampleProcess.loginToEriBank(driver);
            Assert.IsTrue(result);
            Logger.startTestCase("eri login");
        }

    }
}
