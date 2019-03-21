using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Eng24Selenium
{
    /// <summary>
    /// Summary description for SeleniumBBCLoginTest
    /// </summary>
    [TestFixture]
    public class SeleniumBBCLoginTest
    {
        [Test]
        public void SeleniumWalkthrough()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("http://bbc.co.uk");
                IWebElement loginButton = driver.FindElement(By.Id("idcta-link"));
                loginButton.Click();
                IWebElement usernameField = driver.FindElement(By.Id("user-identifier-input"));
                usernameField.SendKeys("testing@goddard.com");
                IWebElement passwordField = driver.FindElement(By.Id("password-input"));
                passwordField.SendKeys("12345678");
                IWebElement submitButton = driver.FindElement(By.Id("submit-button"));
                submitButton.Click();
                IWebElement passwordError = driver.FindElement(By.Id("form-message-password"));
                Assert.AreEqual("Sorry, that password isn't valid. Please include a letter.", passwordError.Text);
            }
        }
    }
}
