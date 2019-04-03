using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WL_Challenge.Test
{
    class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void Initialize() { driver = new ChromeDriver(); }


        [TearDown]
        public void EndTest() { driver.Quit(); }

        
    }
}
