using OpenQA.Selenium;
using POM_test.Helpers;

namespace POM_test.Page
{
    public class TitlePage
    {
        #region Selectors

        private readonly By _logo = By.CssSelector(".logo");

        #endregion

        public bool FindTitle()
        {
            return Driver.webDriver.FindElement(_logo).Displayed;
        }

        public string FindURL()
        {
            return Driver.webDriver.Url;
        }
        public void RefreshPage()
        {
            Driver.webDriver.Navigate().Refresh();
        }
        
    }
}
