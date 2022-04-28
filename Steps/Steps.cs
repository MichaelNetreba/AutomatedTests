using AutomatedTests.Driver;
using AutomatedTests.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace AutomatedTests.CommonTestEntities
{
    public class Steps
    {
        protected IWebDriver webdriver;
        protected LoginElements loginElem;

        public Steps()
        {
            webdriver = DriverSingleton.Instance;
            loginElem = new LoginElements();
        }

        public void OpenPage(string link)
        {
            webdriver.Url = link;
        }

        public void ClickLoginButton()
        {
            WebDriverWait wait = new WebDriverWait(webdriver, TimeSpan.FromSeconds(5));
            loginElem.ButtonLogin.Click();
            wait.Until(e => loginElem.ButtonLoginSubmit.Displayed);
        }

        public void AuthorizeUser(string userName, string password)
        {
            WebDriverWait wait = new WebDriverWait(webdriver, TimeSpan.FromSeconds(5));
            loginElem.LoginUsernameField.SendKeys(userName);
            loginElem.ButtonLoginSubmit.Click();
            wait.Until(e => loginElem.LostYourForgotLink.Displayed);
            loginElem.PasswordUsernameField.SendKeys(password);
            loginElem.ButtonLoginSubmit.Click();
            wait.Until(e => loginElem.ReportIssueButton.Displayed);
        }

        public void CreateReport() => loginElem.ReportIssueButton.Click();

    }
}
