using OpenQA.Selenium;

namespace ConveneAssignment.Pages
{
    public class HomePage
    {
        public HomePage(IWebDriver webDriver)
        {
            Driver = webDriver;

        }

        private IWebDriver Driver { get; }

        public IWebElement SearchText => Driver.FindElement(By.Id("twotabsearchtextbox"));

        public IWebElement ClickSearchButton => Driver.FindElement(By.Id("nav-search-submit-button"));

        public void PutTextSearch(string text)
        {
            SearchText.SendKeys(text);
        }

        public void ClickSearch()
        {
            ClickSearchButton.Click();

        }


    }
}
