using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using POM_test.Helpers;

namespace POM_test.Pages
{
    public class NavbarPage
    {
        #region Selectors

        private readonly By _productList = By.CssSelector("#nav li.level0");

        private readonly By _womenCategory = By.CssSelector(".nav-primary li.level0");
        
        private readonly By _topsAndBlouses = By.CssSelector(".level1.nav-1-2");

        #endregion

        public void NavigateNavbar(string name)
        {
            var products = Driver.webDriver.FindElements(_productList);

            foreach (var product in products)
            {
                if (product.Text.Equals(name))
                {
                    product.Click();
                    break;
                }
            }
        }
        public void HoverCategory()
        {
            Actions actions = new Actions(Driver.webDriver);
            actions.MoveToElement(Driver.webDriver.FindElement(_womenCategory));
            actions.MoveToElement(Driver.webDriver.FindElement(_topsAndBlouses));
            actions.Click().Build().Perform();
        }

    }
}
