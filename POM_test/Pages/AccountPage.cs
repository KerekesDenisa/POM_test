using OpenQA.Selenium;
using POM_test.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM_test.Pages
{
    public class AccountPage
    {
        #region Selectors

        private readonly By _account = By.CssSelector(".skip-link.skip-account");

        private readonly By _accountList = By.CssSelector("#header-account .links");

        #endregion

        public void ClickAccount()
        {
            Driver.webDriver.FindElement(_account).Click();

        }
        public void ClickOnAccountLinks(string name)
        {
            var accountContent = Driver.webDriver.FindElements(_accountList);

            foreach (var element in accountContent)
            {
                if (element.Text.Equals(name))
                {
                    element.Click();
                    break;
                }
            }

        }
    }
}
