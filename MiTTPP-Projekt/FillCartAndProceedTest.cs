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
    public class FillCartAndProceed
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
        public void TheFillCartAndProceedTest()
        {
            driver.Navigate().GoToUrl("https://ferivisport.hr/");
            driver.FindElement(By.XPath("//img[@alt='Žene']")).Click();
            driver.FindElement(By.XPath("//img[@alt='Hlače W Nsw Essntl Pant Tight Flc']")).Click();
            driver.FindElement(By.Id("option-label-ferivi_velicina-136-item-41")).Click();
            driver.FindElement(By.XPath("//button[@id='product-addtocart-button']/span")).Click();
            driver.FindElement(By.Id("btn-minicart-close")).Click();
            driver.FindElement(By.XPath("//img[@alt='Tenisica Wmns Nike Air Max Bella Tr 4']")).Click();
            driver.FindElement(By.Id("option-label-ferivi_velicina-136-item-22")).Click();
            driver.FindElement(By.XPath("//button[@id='product-addtocart-button']/span")).Click();
            driver.FindElement(By.Id("top-cart-btn-checkout")).Click();
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
