using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumDemoCSharp{
    public class Navbar
    {
        public string linkIndex { get; set; } = "s-index";
        public string linkNews { get; set; } = "s-news";
        public string linkContact { get; set; } = "s-contact";
        public string linkAbout { get; set; } = "s-about";
    }
}