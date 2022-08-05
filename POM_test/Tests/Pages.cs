using POM_test.Helpers;
using POM_test.Page;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace POM_test.Tests
{
    public static class Pages
    {
        public static HomePage HomePage => InitPage(new HomePage());
        public static T InitPage<T>(T page)
        {
            PageFactory.InitElements(BaseTest.webDriver, page);
            return page;
        }
    }
    
}
