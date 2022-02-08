using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class BrowseAndAddProductToCart
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }
        
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [Test]
        public void TheBrowseAndAddProductToCartTest()
        {
            driver.Navigate().GoToUrl("https://ferivisport.hr/");
            driver.FindElement(By.XPath("//img[@alt='Muškarci']")).Click();
            driver.FindElement(By.XPath("//main[@id='maincontent']/div[3]/div[2]/div/div")).Click();
            driver.FindElement(By.XPath("//dl[@id='narrow-by-list']/div/dd/form/ul/li/a")).Click();
            driver.FindElement(By.XPath("//img[@alt='Papuče Adilette']")).Click();
            driver.FindElement(By.Id("option-label-ferivi_velicina-136-item-331")).Click();
            driver.FindElement(By.XPath("//button[@id='product-addtocart-button']/span")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
