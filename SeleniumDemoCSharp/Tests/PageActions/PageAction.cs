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
    }
}