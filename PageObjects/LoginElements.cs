using AutomatedTests.Driver;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomatedTests.PageObjects
{
    public class LoginElements
    {
        [FindsBy(How = How.XPath, Using = "//a[contains(@href,'login')]")]
        public IWebElement ButtonLogin;

        [FindsBy(How = How.XPath, Using = "//input[@type = 'submit']")]
        public IWebElement ButtonLoginSubmit;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'username']")]
        public IWebElement LoginUsernameField;

        [FindsBy(How = How.XPath, Using = "//a[contains(@href, 'lost_pwd')]")]
        public IWebElement LostYourForgotLink;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'password']")]
        public IWebElement PasswordUsernameField;

        [FindsBy(How = How.XPath, Using = "//a[text() = ' Report Issue']")]
        public IWebElement ReportIssueButton;

        public readonly By UserNameIcon = By.XPath("//a[text()='MN ( Mike ) ']");

        public LoginElements()
        {
            PageFactory.InitElements(DriverSingleton.Instance, this);
        }
    }
}
