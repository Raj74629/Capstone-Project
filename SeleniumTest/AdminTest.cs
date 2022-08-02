using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTest
{
    [TestClass]
    public class AdminTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://localhost:44310/");
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

            By login = By.LinkText("Login");
            IWebElement Login = driver.FindElement(login);
            Login.Click();

            By email1 = By.XPath("//input[@id='Input_Email']");
            IWebElement Email1 = driver.FindElement(email1);
            Email1.Click();
            Email1.SendKeys("admin@gmail.com");

            By password = By.XPath("//input[@id='Input_Password']");
            IWebElement Password = driver.FindElement(password);
            Password.Click();
            Password.SendKeys("Admin@12345");

            By login2 = By.XPath("//form[@id='account']/div[5]/button");
            IWebElement Login2 = driver.FindElement(login2);
            Login2.Click();

            By type = By.XPath("//a[contains(text(),'Product Type')]");
            IWebElement Type = driver.FindElement(type);
            Type.Click();

            By tag = By.XPath("//a[contains(text(),'Tag Name')]");
            IWebElement Tag = driver.FindElement(tag);
            Tag.Click();

            By product = By.XPath("(//a[contains(text(),'Product')])[2]");
            IWebElement Product = driver.FindElement(product);
            Product.Click();

            By logout = By.XPath("//button[@type='submit']");
            IWebElement Logout = driver.FindElement(logout);
            Logout.Click();
        }
    }
}
