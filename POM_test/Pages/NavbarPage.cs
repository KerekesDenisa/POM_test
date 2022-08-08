using OpenQA.Selenium;
using POM_test.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM_test.Pages
{
    public class NavbarPage
    {
        #region Selectors

        private readonly By _productList = By.CssSelector("#nav li.level0");

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

    }
}
