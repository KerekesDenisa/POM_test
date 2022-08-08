using POM_test.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
