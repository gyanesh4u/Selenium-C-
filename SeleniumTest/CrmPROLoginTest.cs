using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTest
{
    class CrmPROLoginTest
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.crmpro.com/");
            driver.FindElement(By.Name("username")).SendKeys("alok4u");
            driver.FindElement(By.Name("password")).SendKeys("iamalok");
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
            Console.WriteLine(driver.Title);
            driver.Quit();
        }
    }
}
