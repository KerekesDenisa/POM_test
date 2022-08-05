using POM_test.Helpers;
using POM_test.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM_test.Test
{
    public class HomePageTest : BaseTest
    {   
        [Test]
        public void HomepageTest()
        {
            Pages.HomePage.ClickLogo();

            /*StartChromeDriver();
            FindTitle();
            FindURL();
            FindLogo();
            ClickLogo();
            NavigateNavbar("MEN");
            NavigateBack();
            NavigateForward();
            Refresh();
            Assert.That(webDriver.Url, Is.EqualTo("http://qa1magento.dev.evozon.com/men.html"));*/

        }
    }
}
