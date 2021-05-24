using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConveneAssignment.Pages
{
    class ProductPage
    {
        public ProductPage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }
        private IWebDriver Driver { get; }
        public IWebElement Brand => Driver.FindElement(By.Id("bylineInfo"));
        public IWebElement SoldBy => Driver.FindElement(By.XPath("//div[@id='tabular-buybox']//table[@id='tabular-buybox-container']//td[@class='tabular-buybox-column']//span[@id='tabular-buybox-truncate-1']"));

        public string GetBrand()
        {
            return Brand.Text;
        }

        public string GetSoldBy()
        {
            return SoldBy.Text;
        }

    }
}
