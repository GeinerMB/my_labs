using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace UIAutomationTests
{
    public class Selenium
    {
        IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new EdgeDriver();
        }

        [Test]
        public void Enter_To_List_Of_Countries_Test()
        {


            var URL = "http://localhost:8080/";
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(URL);


            IWebElement botonIrAlFormulario = _driver.FindElement(By.CssSelector(".btn-outline-secondary"));
            botonIrAlFormulario.Click();


            IWebElement inputNombre = _driver.FindElement(By.Id("name"));
            inputNombre.SendKeys("Panama");

            IWebElement selectContinente = _driver.FindElement(By.Id("continente"));
            selectContinente.Click();

            selectContinente.SendKeys(Keys.Down);
            selectContinente.SendKeys(Keys.Down);
            selectContinente.SendKeys(Keys.Down);
            selectContinente.SendKeys(Keys.Down);

            selectContinente.SendKeys(Keys.Enter);

            IWebElement inputIdioma = _driver.FindElement(By.Id("idioma"));
            inputIdioma.SendKeys("Ingles");

            IWebElement botonGuardar = _driver.FindElement(By.CssSelector(".btn"));
            botonGuardar.Click();

            //El programa no tiene un mensaje de guardado correctamente por lo que aqui deberia de dar error
            // y no pasar la prueba
            IWebElement mensajeExito = _driver.FindElement(By.XPath("//*[contains(text(), 'País guardado con éxito')]"));
            Assert.That(mensajeExito.Displayed, Is.True, "La página no muestra el mensaje de guardado correctamente.");

            IWebElement celdaPais = _driver.FindElement(By.XPath("//td[text()='Panama']"));
            Assert.That(celdaPais.Displayed, Is.True, "El país 'Panama' no aparece en la tabla.");


            IWebElement celdaIdioma = _driver.FindElement(By.XPath("//td[text()='Ingles']"));
            Assert.That(celdaIdioma.Displayed, Is.True, "El idioma 'Ingles' no aparece en la tabla.");
        }
        [TearDown]
        public void Limpieza()
        {
            if (_driver != null)
            {
                _driver.Quit();
                _driver.Dispose();
            }
        }
    }
}