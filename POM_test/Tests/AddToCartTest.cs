using POM_test.Helpers;
using POM_test.Tests;

namespace POM_test.Tests
{
    public class AddToCartTest : BaseTest
    {
        [Test]
        public void AddToCartPageTest()
        {
            PagesStore.NavbarPage.HoverCategory();

            PagesStore.ProductDetailsPage.SelectFromProductList();

            PagesStore.ProductDetailsPage.SelectColorField();

            PagesStore.ProductDetailsPage.SelectSizeField();

            PagesStore.ProductDetailsPage.InsertQuantity(5);

            PagesStore.ProductDetailsPage.AddToCart();

            Assert.True(PagesStore.ShoppingCartPage.VerifyShoppingCartProduct());
            
        }
    }
}
