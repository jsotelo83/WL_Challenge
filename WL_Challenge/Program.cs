using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WL_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://testapp.galenframework.com/");

            driver.FindElement(By.XPath("//button[@class='btn btn-lg btn-primary button-login']")).Click();

            driver.FindElement(By.Name("login.username")).SendKeys("testuser@example.com");

            driver.FindElement(By.Name("login.password")).SendKeys("test123");

            Thread.Sleep(6000);

            driver.FindElement(By.XPath("//button[@type='button']")).Click();

            Thread.Sleep(6000);



            driver.Quit();

        }
    }
}
