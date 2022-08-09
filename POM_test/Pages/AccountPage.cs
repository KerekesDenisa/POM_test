using OpenQA.Selenium;
using POM_test.Helpers;

namespace POM_test.Pages
{
    public class AccountPage
    {
        #region Selectors

        private readonly By _account = By.CssSelector(".skip-link.skip-account");

        private readonly By _accountList = By.CssSelector("#header-account .links li");

        private readonly By _sectionTitle = By.CssSelector(".page-title h1");
        
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
        public String GetSectionTitle()
        {
            return Driver.webDriver.FindElement(_sectionTitle).Text;
        }
    }
}
