using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;

namespace SeleniumDemoCSharp{
    
    [TestFixture]
    public class AboutSetupTeardown
    {
        // get driver
        protected IWebDriver driver;
        protected string pathDriver = @"..\..\..\..\chromedriver_win32\";
        // get website path
        protected string pathWebsite = @"file:///D:/Computing/Selenium-Project/Website/index.html";
        // get actions
        protected PageAction pageAction;
        // get pages
        protected About about;
        protected Contact contact;
        protected Index index;
        protected Navbar navbar;
        protected News news;

        [SetUp]
        public void BeforeEachTest(){
            
            // get driver
            driver = new ChromeDriver(pathDriver);
            // get actions
            pageAction = new PageAction(this.driver);
            // get pages
            about = new About();
            contact = new Contact();
            index = new Index();
            navbar = new Navbar();
            news = new News();
            // open website homepage
            driver.Navigate().GoToUrl(pathWebsite);
        }
        
        [TearDown]
        public void AfterEachTest(){
            driver.Quit();
        }
        
    }
}