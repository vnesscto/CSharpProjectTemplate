using CSharpProjectTemplate.main.pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProjectTemplate.main.utils
{

    /**
     * This class used for page initialization.
     */
    class ManagePages:DriverManager
    {
        // Web Pages
        public static TestProjectLoginPage testProjectLoginPage;
        public static TestProjectFormPage testProjectFormPage;

        // Desktop Pages
        public static DesktopCalculatorPage desktopCalculatorPage;

        // Mobile pages
        public static MobileLoginPage mobileLoginPage;

        /**
         * This method initializes web pages.
         */
        public static void initWebPages()
        {
            testProjectLoginPage = new TestProjectLoginPage(DriverManager.driver);
            testProjectFormPage = new TestProjectFormPage(DriverManager.driver);
        }


        /**
         * This method initializes desktop pages.
         */
        public static void initDesktopPages()
        {
            desktopCalculatorPage = new DesktopCalculatorPage(DriverManager.driver);
        }


        /**
         * This method initializes mobile pages.
         */
        public static void initMobilePages()
        {
            mobileLoginPage = new MobileLoginPage(DriverManager.driver);
        }
    }
}
