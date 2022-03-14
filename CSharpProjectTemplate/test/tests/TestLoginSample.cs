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
    * This is an example of two tests on Test Project Demo website.
    */
    [AllureNUnit]
    [TestFixture]
    class TestLoginSample :TestBase
    {

        /**
         * This is a login test to test project example website.
         */
        [Test, Description("Verify form saved after fill.")]
        public void login()
        {
            Logger.startTestCase("login");
            Boolean result = TestProjectExampleWebSite.loginToTestProject(driver);
            Assert.IsTrue(result);
            Logger.endTestCase("login");
        }

        /**
         * This is a form fill test on test project example website.
         * The form will appear after a successful Login test.(Previous Test)
         */
        [Test, Description("Verify form saved after fill.") ]
        public void fillForm()
        {
            login();
            Logger.startTestCase("Fill Form");
            String result = TestProjectExampleWebSite.fillTestProjectForm(driver);
            Assert.AreEqual(result, Constants.EXPECTED_TEXT);
            Logger.endTestCase("Fill Form");

        }
    }
}
