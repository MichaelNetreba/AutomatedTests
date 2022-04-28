using AutomatedTests.Driver;
using OpenQA.Selenium;
using System;

namespace AutomatedTests.CommonTestEntities
{
    public class TestsExtensionMethods
    {
        protected IWebDriver webdriver = DriverSingleton.Instance;

        public bool IsElementPresent(By by, TimeSpan time)
        {
            TimeSpan previousTime = webdriver.Manage().Timeouts().ImplicitWait;
            webdriver.Manage().Timeouts().ImplicitWait = time;
            try
            {
                webdriver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException e)
            {
                return false;
            }
            finally
            {
                webdriver.Manage().Timeouts().ImplicitWait = previousTime;

            }
        }
    }
}
