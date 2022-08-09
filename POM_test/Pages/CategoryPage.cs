using OpenQA.Selenium;
using POM_test.Helpers;

namespace POM_test.Pages
{
    public class CategoryPage
    {
        #region Selectors

        private readonly By _categoryName = By.CssSelector(".page-title.category-title h1");

        #endregion
        public bool VerifyCategory(string name)
        {
           return Driver.webDriver.FindElement(_categoryName).Text.Equals(name);
        }


    }
}
