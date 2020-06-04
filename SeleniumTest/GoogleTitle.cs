using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTest
{
    class GoogleTitle
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            driver.Manage().Window.Maximize();
            string title = driver.Title;
            Console.WriteLine("google title is " + title);
            Console.WriteLine(driver.Url);
            Console.WriteLine(driver.PageSource);
            driver.FindElement(By.LinkText("Gmail")).Click();
            driver.Close();
        }
    }
}
