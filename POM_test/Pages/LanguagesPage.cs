using OpenQA.Selenium;
using POM_test.Helpers;

namespace POM_test.Pages
{
    public class LanguagesPage
    {
        #region Selectors

        private readonly By _languagesList = By.CssSelector("#select-language");

        //private readonly By _changeLanguage = By.CssSelector(".form-language label");

        #endregion
        public void ClickLanguages()
        {
            Driver.webDriver.FindElement(_languagesList).Click();
        }

        public void ClickOnLanguagesLinks(string name)
        {
            var languages = Driver.webDriver.FindElements(_languagesList);

            foreach (var element in languages)
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
