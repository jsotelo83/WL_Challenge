using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WL_Challenge.Pages
{
    class LogIn:BasePage
    {
        public LogIn(IWebDriver driver) : base(driver)
        {
                
        }

        By userName = By.Name("login.username");

        By initialBtn = By.Name("login.password");

    }
}
