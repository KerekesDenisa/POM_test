using POM_test.Helpers;

namespace POM_test.Tests
{
    public class NavbarTest : BaseTest
    {
        [Test]
        [TestCase(Constants.NAVBARCATEGORY1)]
        [TestCase(Constants.NAVBARCATEGORY2)]
        [TestCase(Constants.NAVBARCATEGORY3)]
        [TestCase(Constants.NAVBARCATEGORY4)]
        [TestCase(Constants.NAVBARCATEGORY5)]
        [TestCase(Constants.NAVBARCATEGORY6)]

        public void NavbarPageTest(string name)
        {
            PagesStore.NavbarPage.NavigateNavbar(name);
            //PagesStore.CategoryPage.VerifyCategory(name);
            Assert.IsTrue(PagesStore.CategoryPage.VerifyCategory(name));
        }
    }
}
