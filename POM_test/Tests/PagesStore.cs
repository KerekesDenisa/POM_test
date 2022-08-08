using POM_test.Helpers;
using POM_test.Page;
using POM_test.Pages;
using SeleniumExtras.PageObjects;


namespace POM_test.Tests
{
    public static class PagesStore
    {
        public static TitlePage TitlePage => InitPage(new TitlePage());
        public static AccountPage AccountPage => InitPage(new AccountPage());
        public static LanguagesPage LanguagesPage => InitPage(new LanguagesPage());
        public static NavbarPage NavbarPage => InitPage(new NavbarPage());

        public static T InitPage<T>(T page)
        {
            PageFactory.InitElements(Driver.webDriver, page);
            return page;
        }
    }
    
}
