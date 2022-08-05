using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM_test.Helpers
{
    public class BaseTest {

        public static ChromeDriver webDriver;

        [SetUp]
        public void Setup()
        {
            webDriver = new ChromeDriver("C://Users//denis//OneDrive//Desktop//internshipEvozon//POM_test//POM_test");
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("http://qa1magento.dev.evozon.com");
            //webDriver.Navigate().GoToUrl("http://qa2magento.dev.evozon.com");
        }

        [TearDown]
        public void After()
        {
            webDriver.Close();
            webDriver.Quit();
        }
    }
}
