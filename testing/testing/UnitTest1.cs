using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace testing
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;

        
        [Test]
        public void test()
        {
            driver = new ChromeDriver();
            driver.Url = "http://www.yahoo.co.in";
            driver.Close();
        }

        [Test]

        public void GoogleTest()

        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com");

            driver.FindElement(By.Name("q")).SendKeys("Selenium");

            System.Threading.Thread.Sleep(5000);

            driver.FindElement(By.Name("btnK")).Click();

            driver.Close();

        }



        

    }
}
