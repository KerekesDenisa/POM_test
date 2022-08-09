using POM_test.Helpers;

namespace POM_test.Tests
{
    public class LanguagesTest : BaseTest
    {
        [Test]
        public void LanguagesPageTest()
        {
            PagesStore.LanguagesPage.ClickLanguages();

            PagesStore.LanguagesPage.ClickOnLanguagesLinks("German");

        }
    }
}
