using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POM_test.Helpers;

namespace POM_test.Page
{
    public class HomePage
    {
        #region Selectors

        private readonly By getLogo = By.CssSelector(".logo");
        private readonly By productList = By.CssSelector("#nav li.level0");

        #endregion
        public void ClickLogo()
        {
            BaseTest.webDriver.FindElement(getLogo).Click();
        }
         
    }
}
