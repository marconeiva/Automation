using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecflowDemo
{
    [Binding]
    public class SearchSteps
    {
        public IWebDriver driver;
        [Given(@"Launch Chrome browser")]
        public void GivenLaunchChromeBrowser()
        {
            //Launch browser
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"C:\chromedriver_win32", "chromedriver.exe");
            driver = new ChromeDriver(service);
        }
        
        [Given(@"Navigate to code project web site")]
        public void GivenNavigateToCodeProjectWebSite()
        {
            //Navigate to URL https://www.codeproject.com/
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
            driver.Navigate().GoToUrl("https://www.codeproject.com/");
        }
        
        [When(@"Click on Search our articles button")]
        public void WhenClickOnSearchOurArticlesButton()
        {
            //Click on search our articles
            driver.FindElement(By.XPath("//*[@id='ctl00_ContentPane']/div[1]/div/table[1]/tbody/tr/td[3]/a/img")).Click();

        }

        [When(@"Input test data Testing in textfield")]
        public void WhenInputTestDataTestingInTextfield()
        {
            //Enter Testing 
            driver.FindElement(By.Id("ctl00_MC_Query")).SendKeys("Testing");
        }
        
        [When(@"Click on Search Button")]
        public void WhenClickOnSearchButton()
        {
            driver.FindElement(By.Id("ctl00_MC_Go")).Click();
        }
        
        [Then(@"results should be visible and browser should close\.")]
        public void ThenResultsShouldBeVisibleAndBrowserShouldClose_()
        {
            driver.Quit();
        }
    }
}
