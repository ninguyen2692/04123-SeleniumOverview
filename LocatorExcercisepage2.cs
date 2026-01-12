using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationTests
{
    public class LocatorExercisePage2
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
        public void Deletepersion_NameisCierraVega()

        {
            driver.Url="https://demoqa.com/webtables";

        DeleteByFullName("Cierra", "Vega");

        void DeleteByFullName ( string Firstname, string Lastname)
        {
        driver.FindElement(

        By.XPath($"//div[text()='{Firstname}']/following-sibling::div[text() ='{Lastname}']/ancestor::div[@role = 'row']//span[@title = 'Delete']")).Click();

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
      
    
    
        
        
            

