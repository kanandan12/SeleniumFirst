using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class Program
    {
        //Create the reference for our browser
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
            /*
            //Create the reference for our browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Navigate to google page
            driver.Navigate().GoToUrl("http:www.google.com");
            Console.WriteLine("Opened URL");

            //Find the Search text box UI Element
            IWebElement element = driver.FindElement(By.Name("q"));

            //Perform Ops
            element.SendKeys("executeautomation");
            Console.WriteLine("Execute Test");

            //Close the browser
            driver.Close();
            Console.WriteLine("Closed the browser");
            */

            // this is simple changes
        }
               
        [SetUp]
        public void Intialize()
        {
            driver.Manage().Window.Maximize();
            //Navigate to google page
            driver.Navigate().GoToUrl("http:www.google.com");

            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            //Find the Search text box UI Element
            IWebElement element = driver.FindElement(By.Name("q"));

            //Perform Ops
            element.SendKeys("executeautomation");
            Console.WriteLine("Execute Test");
        }

        [Test]
        public void NextTest()
        {
            Console.WriteLine("Next Method");
        }

        [TearDown]
        public void Cleanup()
        {
            //Close the browser
            driver.Close();
            Console.WriteLine("Closed the browser");
        }
        

    }
}
