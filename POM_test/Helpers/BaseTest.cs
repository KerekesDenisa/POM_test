using OpenQA.Selenium.Chrome;

namespace POM_test.Helpers
{
    public class BaseTest {

        [SetUp]
        public void Setup()
        {
            Driver.webDriver = new ChromeDriver();
            Driver.webDriver.Manage().Window.Maximize();
            //Driver.webDriver.Navigate().GoToUrl("http://qa1magento.dev.evozon.com");
            Driver.webDriver.Navigate().GoToUrl("http://qa2magento.dev.evozon.com");
        }

        [TearDown]
        public void After()
        {
            Driver.webDriver.Close();
            Driver.webDriver.Quit();
        }
    }
}
