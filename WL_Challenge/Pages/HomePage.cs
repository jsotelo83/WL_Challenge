using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WL_Challenge.Pages
{
    public class HomePage:BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {

        }

        By initialBtn = By.XPath("//button[@class='btn btn-lg btn-primary button-login']");

        //public void click (By element) { }

        //IWebElement loginBtn = driver.FindElement(initialBtn);
    }
}
