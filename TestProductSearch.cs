using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ConveneAssignment.Pages;
using System;

namespace ConveneAssigment
{
    public class ProductSearch
    {
        //chrome driver
        IWebDriver webDriver = new ChromeDriver(@"C:\Program Files\Google\Chrome\Application");

        [SetUp]
        public void Setup() { }

        [Test]
        public void TestProductSearch()
        {
            //Navigate
            webDriver.Navigate().GoToUrl("https://www.amazon.com/");

            //Search Text
            HomePage homePage = new HomePage(webDriver);

            homePage.PutTextSearch("sunon 40mm fan KDE1205P");
            homePage.ClickSearch();

            //Sort by Pricing
            SearchPage searchPage = new SearchPage(webDriver);
            searchPage.SortLowToHigh();

            // Assert
            string ItemName = searchPage.getFirstItem();
            Assert.That(ItemName.Contains("SUNON") && ItemName.Contains("KDE1205PFB2-8"), Is.True);

            webDriver.Close();
        }
       [TearDown]
        public void TearDown()
        {
            webDriver.Quit();

        }
    }
}