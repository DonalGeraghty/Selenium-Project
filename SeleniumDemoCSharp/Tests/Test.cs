using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;

namespace SeleniumDemoCSharp
{
    [TestFixture]
    public class Test
    {
        // get driver
        IWebDriver driver;
        string path = @"..\..\..\..\chromedriver_win32\";
        // get actions
        PageAction pageAction;
        // get pages
        About about;
        Contact contact;
        Index index;
        Navbar navbar;
        News news;

        [SetUp]
        public void BeforeEachTest(){
            
            // get driver
            driver = new ChromeDriver(path);
            // get actions
            pageAction = new PageAction(this.driver);
            // get pages
            about = new About();
            contact = new Contact();
            index = new Index();
            navbar = new Navbar();
            news = new News();
        }

        [Test]
        public void MyFirstTest(){
            driver.Navigate().GoToUrl("https://www.bing.com/");
        }
        
        [Test]
        public void MySecondTest(){
            driver.Navigate().GoToUrl("http://www.donaljamesgeraghty.com/");
        }

        [Test]
        public void MyThirdTest(){
            driver.Navigate().GoToUrl("file:///D:/Code/Selenium/Selenium-Project/Website/index.html");
            pageAction.Click(index.linkAbout);
            pageAction.Click(about.linkContact);
            pageAction.Click(contact.linkNews);
            pageAction.Click(news.linkIndex);
        }

        [TearDown]
        public void AfterEachTest(){
            driver.Quit();
        }
    }
}