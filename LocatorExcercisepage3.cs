using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationTests
{
    public class LocatorExercisePage3
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
        public void Tiki_selectproductprice()

        {
            driver.Url="https://tiki.vn/";


        {
        driver.FindElement(

        By.XPath("//div[contains(@class,'price-discount')]"));

        }
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}