using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace SeleniumFirst
{
    class LoginPageObject
    {
        [Obsolete]
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.Driver, this);
        }

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement TxtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement TxtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement BtnLogin { get; set; }

        [Obsolete]
        public EAPageObject Login(string userName,string password)
        {
            TxtUserName.EnterText(userName);
            TxtPassword.EnterText(password);
            BtnLogin.Submit();

            return new EAPageObject();
        }
    }
}
