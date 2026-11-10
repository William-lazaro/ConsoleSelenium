
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ConsoleAutomacao.Script;

public class PrimeiroScript
{
    public static void Automatizar_Envio_Texto_ComSucesso()
    {
        IWebDriver driverChrome = new ChromeDriver();

        try
        {
            driverChrome.Navigate().GoToUrl(
                "https://www.selenium.dev/selenium/web/web-form.html"
            );

            var title = driverChrome.Title;

            Console.WriteLine($"Title: {title}");

            driverChrome.Manage().Timeouts().ImplicitWait =
                TimeSpan.FromMilliseconds(500);

            var textBox = driverChrome.FindElement(By.Name("my-text"));

            var submitButton = driverChrome.FindElement(By.TagName("button"));

            textBox.SendKeys("Teste automatizado com Selenium");

            submitButton.Click();
        }
        finally
        {
            driverChrome.Quit();
        }
    }
}
