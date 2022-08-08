using POM_test.Helpers;
using POM_test.Tests;


namespace POM_test.Test
{
    public class TitleTest : BaseTest
    {   
        [Test]
        public void TitlePageTest()
        { 
            PagesStore.TitlePage.FindURL();

            Assert.IsTrue(PagesStore.TitlePage.FindTitle());

            PagesStore.TitlePage.RefreshPage();

            /*
            NavigateBack();
            NavigateForward();
            Refresh();
            Assert.That(webDriver.Url, Is.EqualTo("http://qa1magento.dev.evozon.com/men.html"));*/

        }
    }
}
