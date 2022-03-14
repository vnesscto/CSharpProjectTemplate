using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace CSharpProjectTemplate.main.utils
{

    /**
     * This class contains basic web actions methods.
     */
    class CommonMethods :DriverManager
    {

        /**
         * This method clicks on the element parameter.
         *
         * @param element is the element to be clicked.
         */
       // @Step("Click given web element.")
        public static void click(IWebElement element)
        {
            element.Click();
        }

        /**
         * This method clears text box and send another text
         *
         * @param element is the element to receive keys.
         * @param text    is the text to send.
         */
        //@Step("Send keys to given element.")
        public static void sendText(IWebElement element, String text)
        {
            element.Clear();
            element.SendKeys(text);
        }

        /**
         * This method moves the mouse cursor to the given element.
         *
         * @param element is the element to hover on.
         */
        //@Step("Move to given element.")
        public static void moveToElement(IWebElement element)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(element).Build().Perform();
        }

        /**
         * This method checks if radio/checkbox is enabled and then clicks on the
         * element that has the value we want
         *
         * @param listElement List of elements to be checked by given value.
         * @param value       the value to search on the given list.
         */
        //@Step("Click Radio button or Checkbox.")
        public static void clickRadioButtonOrCheckbox(List<IWebElement> listElement, String value)
        {
            String actualValue;

            foreach (IWebElement el in listElement)
            {
                actualValue = el.GetAttribute("value").Trim();
                if (el.Enabled && actualValue.Equals(value))
                {
                    el.Click();
                }
            }
        }

        /**
         * This method checks if the text is found in the dropdown element and only then
         * selects it
         *
         * @param element      contains the dropdown element.
         * @param textToSelect the desired text to be selected from the dropdown.
         */
        //@Step("Select Dropdown by Text.")
        public static void selectDropDownByText(IWebElement element, String textToSelect)
        {

            try
            {
                SelectElement select = new SelectElement(element);
                IList<IWebElement> options = select.Options;

                foreach (IWebElement el in options)
                {
                    if (el.Text.Equals(textToSelect))
                    {
                        select.SelectByText(textToSelect);
                        break;
                    }
                }
            }
            catch (UnexpectedTagNameException e)
            {
                Console.WriteLine( e.StackTrace);
                Logger.error(Constants.LOG_ERROR_MESSAGE, e);
            }
        }


        /**
         * This method checks if the index is valid and only then selects it
         *
         * @param element contains the dropdown element.
         * @param index   the desired index to be selected from the dropdown.
         */
        //@Step("Select Dropdown by Index.")
        public static void selectDropDownByIndex(IWebElement element, int index)
        {
            try
            {
               SelectElement select = new SelectElement(element);
               int size = select.Options.Count;
                if (size > index && index >= 0)
                {
                    select.SelectByIndex(index);
                }
            }
            catch (UnexpectedTagNameException e)
            {
                Console.WriteLine(e.StackTrace);
                Logger.error(Constants.LOG_ERROR_MESSAGE, e);
            }
        }


        /**
         * This method accepts alerts and catches exception if alert is not present
         */
       // @Step("Accept alert.")
        public static void acceptAlert()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                alert.Accept();
            }
            catch (NoAlertPresentException e)
            {
                Console.WriteLine(e.StackTrace);
                Logger.error(Constants.LOG_ERROR_MESSAGE, e);
            }
        }

        /**
         * This method will dismiss the alert after checking if alert is present
         */
       // @Step("Dismiss Alert.")
        public static void dismissAlert()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                alert.Dismiss();
            }
            catch (NoAlertPresentException e)
            {
                Console.WriteLine(e.StackTrace);
                Logger.error(Constants.LOG_ERROR_MESSAGE, e);
            }
        }


        /**
         * This method switches to frame by using name or id
         *
         * @param nameOrId given id or name to switch to.
         */
        //@Step("Switch to frame by name or id.")
        public static void switchToFrameByNameOrID(String nameOrId)
        {

            try
            {
                driver.SwitchTo().Frame(nameOrId);
            }
            catch (NoSuchFrameException e)
            {
                Console.WriteLine(e.StackTrace);
                Logger.error(Constants.LOG_ERROR_MESSAGE, e);
            }
        }


        /**
         * This method switches to frame by using an index
         *
         * @param index given index to switch to.
         */
        //@Step("Switch to frame by index.")
        public static void switchToFrameByIndex(int index)
        {

            try
            {
                driver.SwitchTo().Frame(index);
            }
            catch (NoSuchFrameException e)
            {
                Console.WriteLine(e.StackTrace);
                Logger.error(Constants.LOG_ERROR_MESSAGE, e);
            }
        }


        /**
         * This method switches to frame by using WebElement
         *
         * @param element given element to switch to.
         */
        //@Step("Switch to frame by element.")
        public static void switchToFrameByElement(IWebElement element)
        {

            try
            {
                driver.SwitchTo().Frame(element);
            }
            catch (NoSuchFrameException e)
            {
                Console.WriteLine(e.StackTrace);
                Logger.error(Constants.LOG_ERROR_MESSAGE, e);
            }
        }


        /**
         * This method switches focus to a child window.
         */
        //@Step("Switch to child window.")
        public static void switchToChildWindow()
        {

            String mainWindow = driver.CurrentWindowHandle;
            IList<String> windows = driver.WindowHandles;
            foreach (String window in windows)
            {
                if (!window.Equals(mainWindow))
                {
                    driver.SwitchTo().Window(window);
                }
            }
        }

        /**
         * This method switches focus to the newest window open.
         *
         * @param previousWindowHandles given previous window handles that were open
         *                              before opening the desired window to switch to.
         */
        public static void switchToNewWindow(IList<String> previousWindowHandles)
        {
            IList<String> currentWindows = driver.WindowHandles;
            foreach (String window in currentWindows)
            {
                if (!previousWindowHandles.Contains(window))
                {
                    driver.SwitchTo().Window(window);
                    break;
                }
            }
        }


        /**
         * This method sends the RETURN key to a given element.
         *
         * @param element given element to send RETURN Key to.
         */
        //@Step("Send RETURN Key.")
        public static void sendReturnKey(IWebElement element)
        {
            element.SendKeys(Keys.Enter);
        }

        /**
         * This method creates a WebDriverWait object and returns it
         *
         * @return
         */
        public static WebDriverWait getWaitObject()
        {
            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(Constants.EXPLICIT_WAIT_TIME));
            return wait;
        }


        /**
         * This method waits for an item to be clickable
         *
         * @param element
         * @return
         */
        public static IWebElement waitForClickability(IWebElement element)
        {
            return getWaitObject().Until(ExpectedConditions.ElementToBeClickable(element));
        }


        /**
         * This method waits for an item to be visibile
         *
         * @param element
         * @return
         */
        public static IWebElement waitForVisibility(By locatorElement)
        {
            return getWaitObject().Until(ExpectedConditions.ElementIsVisible(locatorElement));
        }


        /**
         * This method clicks an element and wait implemented on it
         *
         * @param element
         */
        public static void waitAndClick(IWebElement element)
        {
            waitForClickability(element);
            element.Click();
        }

        /**
         * This method wraps Thread sleep using given second.
         *
         * @param seconds
         */
        public static void wait(int seconds)
        {
            try
            {
                Thread.Sleep(seconds * 1000);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                //Log.error(Constants.LOG_ERROR_MESSAGE, e);
            }
        }


        /**
         * This method casts the driver to a JavascriptExecutor and returns it
         *
         * @return
         */

        public static IJavaScriptExecutor getJSObject()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            return js;
        }

        /**
         * This method will click on the element passed to it used by JavascriptExecutor
         *
         * @param element
         */
        public static void jsClick(IWebElement element)
        {
            getJSObject().ExecuteScript("arguments[0].Click()", element);
        }


        /**
         * This method will scroll the page until the element passed to it becomes visible.
         *
         * @param element
         */
        public static void scrollToElement(IWebElement element)
        {
            getJSObject().ExecuteScript("arguments[0].ScrollIntoView(true)", element);
        }


        /**
         * This method will scroll the page up based on the passed pixel parameter
         *
         * @param pixel
         */
        public static void scrollUp(int pixel)
        {
            getJSObject().ExecuteScript("window[0].ScrollBy(0,-" + pixel + ")");
        }


        /**
         * This method will scroll the page down based on the passed pixel parameter
         *
         * @param pixel
         */
        public static void scrollDown(int pixel)
        {
            getJSObject().ExecuteScript("window[0].ScrollBy(0,+" + pixel + ")");
        }

        /**
         * This method will select date from the calendar
         *
         * @param elements
         * @param text
         */
        public static void selectCalendarDate(List<IWebElement> elements, String text)
        {
            foreach (IWebElement day in elements)
            {
                if (day.Enabled)
                {
                    if (day.Text.Equals(text))
                    {
                        day.Click();
                        break;
                    }
                }
            }
        }


        /**
         * This method will take a screenshot
         *
         * @param fileName
         */

        //public static byte[] takeScreenShot(String fileName)
        //{
        //    ITakesScreenshot ts = (ITakesScreenshot)driver;
        //    byte[] picBytes = ts.GetScreenshot(OutputType.BYTES);
        //    File file = ts.GetScreenshot(OutputType.FILE);
        //    // Create destination as: filepath + filename + timestamp + .png
        //    String destination = Constants.SCREENSHOT_PATH + fileName + getTimeStamp() + ".png";
        //    try
        //    {
        //        FileUtils.copyFile(file, new File(destination));
        //    }
        //    catch (IOException e)
        //    {
        //        Console.WriteLine(e.StackTrace);
        //        Logger.error(Constants.LOG_ERROR_MESSAGE, e);
        //    }

        //    return picBytes;

        //}

        /**
         * This method will return current timestamp in a String
         *
         * @return
         */
        public static String getTimeStamp()
        {
            DateTime date = new DateTime();
            return date.Date.ToString();

        }
    }
}
