using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationTests
{
    public class LocatorExercisePage4
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void OpenGoogle()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            Assert.That(driver.Title, Does.Contain("Google"));
        }

        
        [Test]
        public void Checkindate20Agoda()
        {
            driver.Navigate().GoToUrl("https://www.agoda.com/city/ho-chi-minh-city-vn.html");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            // Chờ search box xuất hiện
            IWebElement searchBoxWrapper = wait.Until(d =>
                d.FindElement(By.XPath("//div[contains(@class,'SearchBox')]"))
            );

            // Click input check-in bằng JS
            IWebElement checkinInput = searchBoxWrapper.FindElement(
                By.XPath(".//input[contains(@placeholder,'Check-in')]")
            );
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", checkinInput);

            // Chờ và click ngày 20
            IWebElement day20 = wait.Until(d =>
                d.FindElement(By.XPath("//div[contains(@class,'DayPicker-Day') and text()='20']"))
            );
            day20.Click();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
    
    
        
        
            

