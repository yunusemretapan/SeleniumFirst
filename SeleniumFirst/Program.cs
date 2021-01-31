using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumFirst
{
    class Program
    {

        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

        }

        [SetUp]
        public void Initialize()
        {

            PropertiesCollection.Driver = new ChromeDriver();

            //Navigate to Google page
            PropertiesCollection.Driver.Navigate().GoToUrl("https://demosite.executeautomation.com/");

            Console.WriteLine("Opened URL");
        }

        [Test]
        [Obsolete]
        public void ExecuteTest()
        {

            //Login to Application

            LoginPageObject loginPageObject = new LoginPageObject();
            EAPageObject eAPageObject = loginPageObject.Login("execute", "automation");

            eAPageObject.FillUserForm("KK", "Karthik", "Automation");


            ////Title
            //SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);

            ////Initial
            //SeleniumSetMethods.EnterText("Initial", "executeautomation", PropertyType.Name);

            //Console.WriteLine("The value from my Title is: " + SeleniumGetMethods.GetTextFromDdl("TitleId", PropertyType.Id));

            //Console.WriteLine("The value from my Initial is: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));

            ////Click
            //SeleniumSetMethods.Click("Save", PropertyType.Name);
        }

        public void NextTest()
        {

        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.Driver.Close();
            Console.WriteLine("Closed the browser");
        }
    }
}
