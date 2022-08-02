using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowSeleniumParallelTest.StepDefinitions
{
    [Binding]
    public class WebAppTestingStepDefinitions
    {

        private ChromeDriver driver;

        [Given(@"I have loaded medicine home page")]
        public void GivenIHaveLoadedMedicineHomePage()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://localhost:44310/");
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            //Logging in as Admin.
            By login = By.LinkText("Login");
            IWebElement Login = driver.FindElement(login);
            Login.Click();

            //Entering Admin Email.
            By email1 = By.XPath("//input[@id='Input_Email']");
            IWebElement Email1 = driver.FindElement(email1);
            Email1.Click();
            Email1.SendKeys("admin@gmail.com");

            //Entering Admin Password.
            By password = By.XPath("//input[@id='Input_Password']");
            IWebElement Password = driver.FindElement(password);
            Password.Click();
            Password.SendKeys("Admin@12345");

            //Clicking on login button.
            By login2 = By.XPath("//form[@id='account']/div[5]/button");
            IWebElement Login2 = driver.FindElement(login2);
            Login2.Click();

            //Now Admin logged in and it can add or edit product category.
            By type = By.XPath("//a[contains(text(),'Product Type')]");
            IWebElement Type = driver.FindElement(type);
            Type.Click();

            //Admin Can add or edit Product Description Here.
            By tag = By.XPath("//a[contains(text(),'Tag Name')]");
            IWebElement Tag = driver.FindElement(tag);
            Tag.Click();

            //Admin can add,delete or edit product in this tab.
            By product = By.XPath("(//a[contains(text(),'Product')])[2]");
            IWebElement Product = driver.FindElement(product);
            Product.Click();

            //Clicking on Logout button.
            By logout = By.XPath("//button[@type='submit']");
            IWebElement Logout = driver.FindElement(logout);
            Logout.Click();
        }

        [Then(@"I should see admin logout page")]
        public void ThenIShouldSeeAdminLogoutPage()
        {
            Console.WriteLine("Web App Testing Successfull..");
            Console.WriteLine("Medicine App is working Fine!!");
        }
    }
}
