using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace SeleniumFirst
{
    class EAPageObject
    {
        [Obsolete]
        public EAPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.Driver, this);
        }

        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement DdlTitleId { get; set; }

        [FindsBy(How = How.Id, Using = "Initial")]
        public IWebElement TxtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement TxtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement TxtMiddleName { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement BtnSave { get; set; }


        public void FillUserForm(string initial, string firstName, string middleName)
        {
            TxtInitial.EnterText(initial);
            TxtFirstName.EnterText(firstName);
            TxtMiddleName.EnterText(middleName);
            BtnSave.Clicks();


            //SeleniumSetMethods.EnterText(TxtInitial, initial);
            //SeleniumSetMethods.EnterText(TxtFirstName, firstName);
            //SeleniumSetMethods.EnterText(TxtMiddleName, middleName);
            //SeleniumSetMethods.Click(BtnSave);


            //TxtInitial.SendKeys(initial);
            //TxtFirstName.SendKeys(firstName);
            //TxtMiddleName.SendKeys(middleName);
            //BtnSave.Click();
        }
    }
}
