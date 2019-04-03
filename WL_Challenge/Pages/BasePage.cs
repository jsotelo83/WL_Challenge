using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WL_Challenge.Pages
{
    public class BasePage
    {

        public IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void click (By element) { driver.FindElement(element).Click(); }

        public void setValue (By element, string value) { driver.FindElement(element).SendKeys(value); }

    }
}
