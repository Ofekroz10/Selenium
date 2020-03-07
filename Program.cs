using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        /* IWebDriver- driver to create a reference to any browser:
        ChromeDriver, FirefoxDriver... */

        static void Main(string[] args)
        {

        }

        [SetUp] //Called before each test
        public void Init()
        {
            PropertiesCollection.driver = new ChromeDriver();
            /* Navigate to google page, Navigate function return INavigation, that have the function GoToUrl */
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            Console.WriteLine("Called SetUp");
        }

        [Test]
        public void ExcuteTest()
        {
            //Init prop
            LoginPageObject login_page = new LoginPageObject();
            SecondPage userPage = login_page.Login("Ofek", "12345");
            userPage.FillUserForm("initial", "ofek-middle", "Ofek");

        }


        [TearDown] 
        public void Clean()
        {
            Console.WriteLine("Close");
            PropertiesCollection.driver.Close();
        }
    }
}
