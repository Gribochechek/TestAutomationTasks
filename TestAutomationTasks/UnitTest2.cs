using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace TestAutomationTasks
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            // Creates a new Chrome instance and opens the browser
            driver.Navigate().GoToUrl("https://www.bbc.com");
                        
            IWebElement element = driver.FindElement(By.XPath("/html/body/header/div/div[1]/nav/div/ul/li[2]/a"));
            element.Click();

            
            IWebElement el1 = driver.FindElement(By.XPath("/html/body/div[7]/div/div[4]/div[2]/div/div/div/div/div[1]/div/div/div[1]/div/a/h3"));
            string el1Text = el1.Text;
            Assert.AreEqual("Trump faces impeachment vote", el1Text);

            driver.Quit();


            // Navigates to a page by address


        }
    }
}
