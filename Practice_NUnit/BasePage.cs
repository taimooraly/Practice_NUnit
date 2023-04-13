using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Practice_NUnit
{
    public class BasePage
    {
        public static IWebDriver driver;
        public void SeleniumInitialize(string browser)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        public void SeleniumClose()
        {
            driver.Close();
        }
        public void SeleniumOpen()
        {

        }
    }
}