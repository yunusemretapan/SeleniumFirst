using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    public static class SeleniumSetMethods
    {
        /// <summary>
        /// Extended method for entering text in the control
        /// </summary>
        /// <param name="webElement"></param>
        /// <param name="value"></param>
        public static void EnterText(this IWebElement webElement, string value)
        {
            webElement.SendKeys(value);
        }

        /// <summary>
        /// Click into a button, checkbox, option etc
        /// </summary>
        /// <param name="webElement"></param>
        public static void Clicks(this IWebElement webElement)
        {
            webElement.Click();
        }

        /// <summary>
        /// Selecting a dropdown control
        /// </summary>
        /// <param name="webElement"></param>
        /// <param name="value"></param>
        public static void SelectDropDown(this IWebElement webElement, string value)
        {
            new SelectElement(webElement).SelectByText(value);
        }
    }
}
