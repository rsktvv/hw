using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using OpenQA.Selenium.DevTools.V120.Input;
using System.Security.Policy;
using OpenQA.Selenium.Support.Extensions;



namespace testbot
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://b24-qdke09.bitrix24.ru/stream/?current_fieldset=SOCSERV");

            var login = driver.FindElement(By.XPath("//input[@id='login']"));
            login.SendKeys("shishenin111@gmail.com");
            Thread.Sleep(100);
            login.SendKeys(Keys.Enter);
            Thread.Sleep(1000);


            WebDriverWait wait_password = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            var password = wait_password.Until(d => d.FindElement(By.XPath("//input[@id='password']")));
            password.SendKeys("Zaqxsw123");
            Thread.Sleep(100);
            password.SendKeys(Keys.Enter);
            Thread.Sleep(1000);

        }
    }
}
