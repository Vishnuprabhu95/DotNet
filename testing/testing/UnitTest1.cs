using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;

using System.Threading.Tasks;
namespace testing
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;



        string EnvBrw = System.Environment.GetEnvironmentVariable("Browser");





        [SetUp]
        public void startBrowser()
        {
            if(EnvBrw.Equals("Chrome"))
            {
                driver = new ChromeDriver();
            }
            else if (EnvBrw.Equals("Firefox"))
            {
                driver = new FirefoxDriver();
            }
            
        }

        [Test]
        public void test()
        {
            driver.Url = "http://www.yahoo.co.in";
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
