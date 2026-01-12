using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationTests
{
    public class LocatorExercisePage1
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
        public void RegisterStudentSuccessfully()
        {
            driver.Url="https://demoqa.com/automation-practice-form";

            // username

            IWebElement inputfirstName = driver.FindElement(By.Id("firstName"));
            inputfirstName.SendKeys("Ni");

            IWebElement inputlastName = driver.FindElement(By.Id("lastName"));
            inputlastName.SendKeys("Nguyen");

            // email

            IWebElement inputuserEmail = driver.FindElement(By.Id("userEmail"));
            inputuserEmail.SendKeys("NiNguyen@gmail.com");

            //gender dung By.XPATH vì ko có Chữ để click By.XPath(text()), Checkbox / Radio By.XPath(label), Dropdown React By.XPath(contains())

            SelectByLabelText("Male"); 
             void SelectByLabelText(string text)
            {
            driver.FindElement(
                By.XPath($"//label[text()='{text}']")
            ).Click();
            }

            // phone number 
            IWebElement inputuserNumber = driver.FindElement(By.Id("userNumber"));
            inputuserNumber.SendKeys("0123456435");

            // Subjects
            SelectSubject("Maths");
            SelectSubject("Arts");
             void SelectSubject(string subject)
             {
            IWebElement subjectInput = driver.FindElement(By.Id("subjectsInput"));
            subjectInput.SendKeys(subject);
            subjectInput.SendKeys(Keys.Enter);
            }


            // Hobbies dùng chung hàm với gender ko cần viết lại 
            SelectByLabelText("Sports");
            SelectByLabelText("Reading");
           


            //current Address
             IWebElement inputcurrentAddress = driver.FindElement(By.Id("currentAddress"));
            inputcurrentAddress.SendKeys("364 Cong Hoa, HCM city");

            // State & City
            SelectDropdown("state", "NCR");
            SelectDropdown("city", "Delhi");

            void SelectDropdown (string dropdownId, string value)
            {
            driver.FindElement(By.Id(dropdownId)).Click();
            driver.FindElement(By.XPath($"//div[contains(@id,'react-select') and text()='{value}']")).Click();
            }

            //Submit
            driver.FindElement(By.Id("submit")).Click();

        
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
      
    
    
        
        
            

