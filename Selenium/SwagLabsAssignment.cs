using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumCSharp.Selenium
{
    internal class SwagLabsAssignment
    {
        ChromeDriver chromeDriver;
        [SetUp]
        public void startbrowser()
        {
            // configuring chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            // initialized driver
            chromeDriver = new ChromeDriver();

            chromeDriver.Navigate().GoToUrl("https://www.saucedemo.com/");

            chromeDriver.Manage().Window.Maximize();
        }


        [Test]
        public void test()
        {
            // Username input
            IWebElement UsernameInput = chromeDriver.FindElement(By.XPath("//input[@id='user-name']"));
            UsernameInput.SendKeys("standard_user");

            // Password Input
            IWebElement PasswordInput = chromeDriver.FindElement(By.XPath("//input[@id='password']"));
            PasswordInput.SendKeys("secret_sauce");

            Thread.Sleep(2000);

            // Clicking login button
            IWebElement LoginButton = chromeDriver.FindElement(By.XPath("//input[@id='login-button']"));
            LoginButton.Click();

            Thread.Sleep(2000);

            // Handling Add to cart button

            IWebElement AddToCartButton = chromeDriver.FindElement(By.XPath("//button[@id='add-to-cart-sauce-labs-backpack']"));
            AddToCartButton.Click();

            Thread.Sleep(2000);

            // Going to cart
            IWebElement GotoCart = chromeDriver.FindElement(By.XPath("//a[@class='shopping_cart_link']"));
            GotoCart.Click();

            Thread.Sleep(2000);

            // Clicking Checkout button
            IWebElement CheckoutButton = chromeDriver.FindElement(By.XPath("//button[@id='checkout']"));
            CheckoutButton.Click();

            Thread.Sleep(2000);

            // Handling firstname input field
            IWebElement FirstnameInput = chromeDriver.FindElement(By.XPath("//input[@id='first-name']"));
            FirstnameInput.SendKeys("Charan");

            // Handling Lastname input field
            IWebElement LastNameInput = chromeDriver.FindElement(By.XPath("//input[@id='last-name']"));
            LastNameInput.SendKeys("Kulal");

            // Handling zip/postal code
            IWebElement PostCodeInput = chromeDriver.FindElement(By.XPath("//input[@id='postal-code']"));
            PostCodeInput.SendKeys("574242");

            Thread.Sleep(2000);

            // Clicking on continue button
            IWebElement ContinueButton = chromeDriver.FindElement(By.XPath("//input[@id='continue']"));
            ContinueButton.Click();

            Thread.Sleep(2000);

            // Clicking Finish Button
            IWebElement FinishButton = chromeDriver.FindElement(By.XPath("//button[@id='finish']"));
            FinishButton.Click();

            Thread.Sleep(2000);

            // Message comparision
            IWebElement Message = chromeDriver.FindElement(By.XPath("//h2[@class='complete-header']"));
            string Res = Message.Text;

            Assert.That(Res.Equals("Thank you for your order!"));



        }

        [TearDown]
        public void tearDown()
        {
            Thread.Sleep(2000);
            chromeDriver.Dispose();
        }
    }
}
