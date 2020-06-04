using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Name("q")).SendKeys("selenium");
            driver.FindElement(By.Name("btnK")).Click();
            driver.Quit();
        }
    }
}
