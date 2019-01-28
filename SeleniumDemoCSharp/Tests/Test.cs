using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumDemoCSharp
{
    [TestFixture]
    public class Test
    {
        IWebDriver driver;
        string path = @"..\..\..\..\chromedriver_win32\";

        [SetUp]
        public void BeforeEachTest(){
            //var location = System.IO.Directory.GetCurrentDirectory();

            driver = new ChromeDriver(path);
        }

        [Test]
        public void MyFirstTest(){
            driver.Navigate().GoToUrl("https://www.bing.com/");
        }
        
        [Test]
        public void MySecondTest(){
            driver.Navigate().GoToUrl("http://www.donaljamesgeraghty.com/");
        }

        [TearDown]
        public void AfterEachTest(){
            driver.Close();
        }
    }
}