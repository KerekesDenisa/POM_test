using POM_test.Helpers;

namespace POM_test.Tests
{
    public class AccountTest : BaseTest
    {
        [Test]
        [TestCase(Constants.MYACCOUNT,Constants.MYACCOUNT_TITLE)]
        [TestCase(Constants.MYWISHLIST,Constants.MYWISHLIST_TITLE)]
        [TestCase(Constants.MYCART, Constants.MYCART_TITLE)]
        [TestCase(Constants.CHECKOUT, Constants.CHECKOUT_TITLE)]
        [TestCase(Constants.REGISTER, Constants.REGISTER_TITLE)]
        [TestCase(Constants.LOGIN, Constants.LOGIN_TITLE)]
        public void AccountPageTest(string name, string title)
        {

            PagesStore.AccountPage.ClickAccount();

            PagesStore.AccountPage.ClickOnAccountLinks(name);

            Assert.That(title, Is.EqualTo(PagesStore.AccountPage.GetSectionTitle()));

        }

    }
}
