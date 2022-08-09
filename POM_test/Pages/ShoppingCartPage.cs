using OpenQA.Selenium;
using POM_test.Helpers;

namespace POM_test.Pages
{
    public class ShoppingCartPage
    {
        #region Selectors

        private readonly By _shoppingCartProductList = By.CssSelector("#shopping-cart-table tbody > tr");

        #endregion

        public bool VerifyShoppingCartProduct()
        {
            return Driver.webDriver.FindElement(_shoppingCartProductList).Displayed;
        }
    }
}
