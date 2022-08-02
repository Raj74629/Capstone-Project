using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTest
{
    [TestClass]
    public class CustomerTest
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
            Email1.SendKeys("demo@gmail.com");

            By password = By.XPath("//input[@id='Input_Password']");
            IWebElement Password = driver.FindElement(password);
            Password.Click();
            Password.SendKeys("Demo@12345");

            By login2 = By.XPath("//form[@id='account']/div[5]/button");
            IWebElement Login2 = driver.FindElement(login2);
            Login2.Click();

            //finding webelement by id
            By details = By.XPath("(//a[contains(text(),'Deatils')])[2]");
            IWebElement Details = driver.FindElement(details);
            Details.Click();

            By cart = By.XPath("//input[@value='Add to Cart']");
            IWebElement Cart = driver.FindElement(cart);
            Cart.Click();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            By order = By.XPath("//a[contains(.,' (1)')]");
            IWebElement Order = driver.FindElement(order);
            Order.Click();

            By checkout = By.LinkText("Process to Checkout");
            IWebElement Checkout = driver.FindElement(checkout);
            Checkout.Click();

            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

            By name = By.XPath("//input[@id='Name']");
            IWebElement Name = driver.FindElement(name);
            Name.Click();
            Name.SendKeys("Rohan Sharma");

            By number = By.XPath("//input[@id='PhoneNo']");
            IWebElement Number = driver.FindElement(number);
            Number.Click();
            Number.SendKeys("9906073825");

            By address = By.XPath("//input[@id='Address']");
            IWebElement Address = driver.FindElement(address);
            Address.Click();
            Address.SendKeys("Muzaffarpur,Bihar,India");

            By email = By.XPath("//input[@id='Email']");
            IWebElement Email = driver.FindElement(email);
            Email.Click();
            Email.SendKeys("rohan12@gmail.com");

            By date = By.XPath("//input[@id='OrderDate']");
            IWebElement Date = driver.FindElement(date);
            Date.Click();

            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

            By date2 = By.XPath("//input[@id='OrderDate']");
            IWebElement Date2 = driver.FindElement(date2);
            Date2.Click();

            By placeorder = By.XPath("//input[@value='Place Order']");
            IWebElement Placeorder = driver.FindElement(placeorder);
            Placeorder.Click();

            By logout = By.XPath("//button[@type='submit']");
            IWebElement Logout = driver.FindElement(logout);
            Logout.Click();
        }
    }
}
