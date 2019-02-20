using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumDemoCSharp{
    public class PageAction
    {
        IWebDriver driver;
        public PageAction(IWebDriver driver){
            this.driver = driver;
        }

        public void Click(string locator){
            driver.FindElement(By.Id(locator)).Click();
        }

        public string GetText(string locator){
            return driver.FindElement(By.Id(locator)).Text;
        }

        public void Assert(string expected, string actual){
            if (!string.Equals(expected, actual)){
                throw new Exception($"FAIL: expected: {expected} does not equal: {actual}");
            }
        }
    }
}