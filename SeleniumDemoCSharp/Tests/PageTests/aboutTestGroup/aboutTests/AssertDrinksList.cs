using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;

namespace SeleniumDemoCSharp{

    public class AssertDrinksList : AboutSetupTeardown
    {
        [Test]
        public void AssertDrinksListTest(){
            pageAction.Click(index.linkAbout);
            pageAction.Assert("Milk", pageAction.GetText(about.listDrinksMilk));
            pageAction.Assert("Coffee", pageAction.GetText(about.listDrinksCoffee));
            pageAction.Assert("Tea", pageAction.GetText(about.listDrinksTea));
        }
    }
}