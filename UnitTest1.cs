using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationTests
{
    public class Tests
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
        public void loginGuru()
        {
            driver.Url="https://demo.guru99.com/V1/index.php";

            IWebElement inputusername = driver.FindElement(By.Name("uid"));
            inputusername.SendKeys("abc");

            IWebElement inputpassword = driver.FindElement(By.Name("password"));
            inputpassword.SendKeys("abcd@1234");

        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
      
    
    
        
        
            

