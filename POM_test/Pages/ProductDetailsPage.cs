using NsTestFrameworkUI.Pages;
using OpenQA.Selenium;
using POM_test.Helpers;

namespace POM_test.Pages
{
    public class ProductDetailsPage

    {
        #region Selectors

        private readonly By _productList = By.CssSelector(".category-products > ul > li");

        private readonly By _colorList = By.CssSelector(".configurable-swatch-list.configurable-swatch-color.clearfix");

        private readonly By _configColorList = By.CssSelector("#configurable_swatch_color li");

        private readonly By _configSizeList = By.CssSelector("#configurable_swatch_size li");

        private readonly By _quantity = By.CssSelector("#qty");

        private readonly By _inventory = By.CssSelector(".availability.in-stock .value");

        private readonly By _addToCart = By.CssSelector(".add-to-cart-buttons .button.btn-cart");

        #endregion
        public void SelectFromProductList()
        {
            var productList = Driver.webDriver.FindElements(_productList);

            List<IWebElement> productsWithColorOptionList = new List<IWebElement>();

            foreach (var productItem in productList)
            {
                try
                {
                    productItem.FindElement(_colorList);
                    productsWithColorOptionList.Add(productItem);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Products without color option");
                }
            }
            productsWithColorOptionList[0].Click();
        }

        public void SelectColorField()
        {

            Driver.webDriver.FindElements(_configColorList)[0].Click();
        }
        public void SelectSizeField()
        {
            Driver.webDriver.FindElements(_configSizeList)[1].Click();

        }
        public void InsertQuantity(int q)
        {
            var quantity = Driver.webDriver.FindElement(_quantity);
            quantity.Clear();
            quantity.SendKeys(q.ToString());
        }

        public bool VerifyInventory()
        {
            return _inventory.GetText().Equals("IN STOCK");
        }

        public void AddToCart()
        {
            Driver.webDriver.FindElement(_addToCart).Click();
        }
    }
}
