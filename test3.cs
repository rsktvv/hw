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

            WebDriverWait wait_file = new WebDriverWait(driver, TimeSpan.FromSeconds(200));
            var file = wait_file.Until(d => d.FindElement(By.XPath("//i[@id='bx-b-uploadfile-blogPostForm']")));
            Thread.Sleep(1000);
            file.Click();
            Thread.Sleep(1000);

            WebDriverWait wait_input_file = new WebDriverWait(driver, TimeSpan.FromSeconds(200));
            var input_file1 = wait_input_file.Until(d => d.FindElement(By.XPath("//input[@id='ui-tile-uploader-file-proxy']")));
            input_file1.SendKeys("C:\\Users\\shish\\Downloads\\qqq.mp4");
            Thread.Sleep(1000);

            var send = driver.FindElement(By.XPath("//span[@id='blog-submit-button-save']"));
            send.Click();
            driver.Quit();
        }
    }
}
