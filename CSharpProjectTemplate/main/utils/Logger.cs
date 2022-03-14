using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProjectTemplate.main.utils
{
    class Logger
    {
        private static readonly log4net.ILog Log =log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        // This is to print log for the beginning of the test case, as we usually run so many test cases as a test suite
        public static void startTestCase(String sTestCaseName)
        {

            Log.Info("****************************************************************************************");

            Log.Info("****************************************************************************************");

            Log.Info("$$$$$$$$$$$$$$$$$$$$$                 " + sTestCaseName + "       $$$$$$$$$$$$$$$$$$$$$$$$$");

            Log.Info("****************************************************************************************");

            Log.Info("****************************************************************************************");

        }

        //This is to print log for the ending of the test case

        public static void endTestCase(String sTestCaseName)
        {

            Log.Info("XXXXXXXXXXXXXXXXXXXXXXX             " + "-E---N---D-" + "             XXXXXXXXXXXXXXXXXXXXXX");

            Log.Info("X");

            Log.Info("X");

            Log.Info("X");

            Log.Info("X");

        }
       

        // Log level methods

        public static void info(String message)
        {

            Log.Info(message);
        }

        public static void warn(String message)
        {

            Log.Warn(message);

        }

        public static void error(String message, Exception e)
        {

            Log.Error(message, e);

        }

        public static void fatal(String message)
        {

            Log.Fatal(message);

        }

        public static void debug(String message)
        {

            Log.Debug(message);

        }
    }
}
