
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestAutomationTasks
{
    [TestClass]
    public class UnitTest3
    {
        
        [TestMethod]
        public void TestMethod2()    {

            List<String> artList = new List<string>();
            artList.Add("'Brexit will harm UK more than EU'");
            artList.Add("Australia heatwave: Nation endures hottest day on record");
            artList.Add("Hernan Cortes: Conquistador anchors found off Mexico Gulf Coast");
            artList.Add("Adam Driver leaves interview 'because he can't stand listening to himself'");
            artList.Add("People with epilepsy targeted in Twitter attack");



            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            // Creates a new Chrome instance and opens the browser
            driver.Navigate().GoToUrl("https://www.bbc.com/news");

            IList<IWebElement> articlesList = driver.FindElements(By.CssSelector(".gs-c-promo-heading__title gel-pica-bold nw-o-link-split__text"));
                
            for(int i =0; i<articlesList.Count; i++)
            {
                Assert.AreEqual(artList.Contains(articlesList.ElementAt(i).Text), articlesList.ElementAt(i));
            }
            driver.Quit();
        }
        
        

    }
}
