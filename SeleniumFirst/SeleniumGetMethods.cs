using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Linq;

namespace SeleniumFirst
{
    class SeleniumGetMethods
    {
        public static string GetText(IWebElement webElement)
        {
            return webElement.GetAttribute("value");
        }

        public static string GetTextFromDdl(IWebElement webElement)
        {
            return new SelectElement(webElement).AllSelectedOptions.SingleOrDefault().Text;
        }
    }
}
