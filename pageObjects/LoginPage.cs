using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSelFrameworkWithPageFactory.pageObjects
{
    public class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver) // Constructor to pass the driver object from calling class(EndToEnd.cs)
        {
            this.driver = driver; // this.driver is the local variable
            PageFactory.InitElements(driver, this); // here, this is the object
        }

        [FindsBy(How = How.Id, Using = "username")]
        private IWebElement username;

        public IWebElement getUserName()
        {
            return username;
        }







    }






}
