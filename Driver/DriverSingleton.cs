using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomatedTests.Driver
{
    public class DriverSingleton
    {
        private static WebDriver webdriver;
        private DriverSingleton()
        {

        }

        public static WebDriver Instance 
        {
            get 
            {
                if (webdriver == null) 
                {
                    webdriver = new ChromeDriver();
                }
                return webdriver;
            } 
        }

        public static void CloseWebDriver()
        {
            webdriver.Quit();
            webdriver = null;
        }
    }
}
