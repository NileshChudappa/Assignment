using ConveneAssignment.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ConveneAssigment
{
    public class ProductDetail
    {
        //chrome driver
        public IWebDriver webDriver = new ChromeDriver(@"C:\Program Files\Google\Chrome\Application");

        [SetUp]
        public void Setup()
        { 
        }

        [Test]
        public void TestProduct()
        {
            //Navigate
            webDriver.Navigate().GoToUrl("https://www.amazon.com/dp/B0085YAA3U/");

            //Get product details
            ProductPage productPage = new ProductPage(webDriver);
            String Brand = productPage.GetBrand();
            String SoldBy = productPage.GetSoldBy();

            // Assert
            Assert.That(Brand.Equals("Brand: Sunon") && SoldBy.Equals("Coolerguys"), Is.True);
            webDriver.Close();
        }
        [TearDown]
        public void TearDown()
        {
            webDriver.Quit();

        }
    }
}