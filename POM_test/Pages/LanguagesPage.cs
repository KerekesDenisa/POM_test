using OpenQA.Selenium;
using POM_test.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM_test.Pages
{
    public class LanguagesPage
    {
        #region Selectors

        private readonly By _languagesList = By.CssSelector("#select-language");

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
