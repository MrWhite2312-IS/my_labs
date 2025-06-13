using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UIAutomationTests
{
    public class Selenium
    {
        private ChromeDriver _driver; 

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
        }

        [Test]
        public void Enter_To_List_Of_Countries_Test()
        {
            var URL = "http://localhost:8080/";
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(URL);
            Assert.IsNotNull(_driver);
        }

        [Test]
        public void Add_country()
        {
            var URL = "http://localhost:8080/";
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(URL);

            IWebElement addCountryButton = null;
            IWebElement countryNameInput = null;
            IWebElement continentSelect = null;
            IWebElement languageInput = null;
            IWebElement saveButton = null;

            addCountryButton = _driver.FindElement(By.XPath("//button[contains(text(),'Agregar Pais')]"));
            addCountryButton.Click();

            countryNameInput = _driver.FindElement(By.Id("name"));
            countryNameInput.Clear();
            countryNameInput.SendKeys("España");

            continentSelect = _driver.FindElement(By.Id("continente"));
            var selectElement = new OpenQA.Selenium.Support.UI.SelectElement(continentSelect);
            selectElement.SelectByText("Europa");

            languageInput = _driver.FindElement(By.Id("idioma"));
            languageInput.Clear();
            languageInput.SendKeys("Español");

            saveButton = _driver.FindElement(By.XPath("//button[contains(text(),'Guardar')]"));
            saveButton.Click();
            Assert.IsNotNull(_driver);
        }

        [TearDown]
        public void TearDown() // Added TearDown method for NUnit1032
        {
            _driver?.Dispose();
        }
    }
}

