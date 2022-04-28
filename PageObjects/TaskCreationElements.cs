using AutomatedTests.Driver;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomatedTests.PageObjects
{
    public class TaskCreationElements
    {
        [FindsBy(How = How.XPath, Using = "//select[@id = 'reproducibility']")]
        public IWebElement DropDownReproducibility;

        [FindsBy(How = How.XPath, Using = "//input[@id = 'summary']")]
        public IWebElement FieldSummary;

        [FindsBy(How = How.XPath, Using = "//textarea[@id = 'description']")]
        public IWebElement FieldDescription;

        [FindsBy(How = How.XPath, Using = "//input[@type = 'submit']")]
        public IWebElement ButtonSumbitReport;

        public readonly By ReportID = By.XPath("//th[contains(@class, 'bug-id')]");

        public TaskCreationElements()
        {
            PageFactory.InitElements(DriverSingleton.Instance, this);
        }
    }
}
