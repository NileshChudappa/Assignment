using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConveneAssignment.Pages
{
    public class SearchPage
    {
        public SearchPage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }
        private IWebDriver Driver { get; }

        public IWebElement SortButton => Driver.FindElement(By.ClassName("a-dropdown-prompt"));
        public IWebElement LowToHigh => Driver.FindElement(By.Id("s-result-sort-select_1"));

        public IWebElement FirstItem => Driver.FindElement(By.XPath("//div[@data-index=0]//span[contains(@class,'a-size-medium')]"));

        public void SortLowToHigh()
        {
            SortButton.Click();
            LowToHigh.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

        public string getFirstItem()
        {
            return FirstItem.Text;
        }


    }
}
