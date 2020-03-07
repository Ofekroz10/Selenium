using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class SecondPage
    {
        public SecondPage()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement TitleId { get; set; }

        [FindsBy(How = How.Id, Using = "FirstName")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement Save_Button { get; set; }

        [FindsBy(How = How.Id, Using = "Initial")]
        public IWebElement Initial { get; set; }

        [FindsBy(How = How.Id, Using = "MiddleName")]
        public IWebElement MiddleName { get; set; }


        public void FillUserForm(string initial, string middleName, string firstName)
        {
            this.MiddleName.SendKeys(middleName);
            this.Initial.SendKeys(initial);
            this.FirstName.SendKeys(firstName);
            this.Save_Button.Click();
        }

    }
}
