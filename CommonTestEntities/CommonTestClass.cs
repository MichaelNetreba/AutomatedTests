using AutomatedTests.CommonTestEntities;
using AutomatedTests.Driver;
using NUnit.Framework;

namespace AutomatedTests.CommonTestObjects
{
    public class CommonTestClass 
    {
        protected Steps steps;

        [OneTimeSetUp]
        public void Start_Browser()
        {
            DriverSingleton.Instance.Manage().Window.Maximize();
            steps = new Steps();
        }

        [OneTimeTearDown]
        public void Close_Browser()
        {
            DriverSingleton.CloseWebDriver();
        }
    }
}
