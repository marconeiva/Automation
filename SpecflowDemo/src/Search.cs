using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace SpecflowDemo
{
    public class Search
    {
        [Test]
        public void Search_Test()
        {
            //Launch browser
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"C:\chromedriver_win32" ,"chromedriver.exe");
            IWebDriver driver = new ChromeDriver(service);

            //Navigate to URL https://git-scm.com/
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(3);
            driver.Navigate().GoToUrl("https://git-scm.com/");

            //Click on About Link
            driver.FindElement(By.XPath("//*[@id='nav - about']/a")).Click();

            //Enter Testing 
            driver.FindElement(By.Id("search-results")).SendKeys("Testing");

            //Click on Small and Fast Link
            driver.FindElement(By.XPath("//*[@id='content - wrapper']/aside/nav/ul/li[1]/ul/li[2]/a")).Click();

            driver.Quit();
        }

    }
}
