using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace SpecflowDemo
{
    public class ClickTest
    {
        [Test]
        public void Click_Test()
        {
            //Launch browser
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"C:\Users\MasterMarco\Downloads\chromedriver_win32", "chromedriver.exe");
            IWebDriver driver = new ChromeDriver(service);

            //Navigate to URL https://www.codecademy.com/
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(3);
            driver.Navigate().GoToUrl("https://www.codecademy.com/");

            //Click on Catalog Link
            driver.FindElement(By.XPath("//*[@id='catalog']")).Click();

            //Click on HTML and CSS Link
            driver.FindElement(By.XPath("/html/body/div[1]/div[1]/nav/div/div[2]/div/span[1]/div/a")).Click();

            driver.Quit();
        }
    }
}
