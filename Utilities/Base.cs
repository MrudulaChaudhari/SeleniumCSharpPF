using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using System.Configuration;
using NUnit.Framework;

namespace CSharpSelFrameworkWithPageFactory.Utilities
{
    public class Base
    {

        public IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
           //var browserName = ConfigurationManager.AppSettings["browser"];
          //TestContext.Progress.WriteLine(browserName);
          
            InitBrowser("Chrome");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //Maximizing the window
            driver.Manage().Window.Maximize();
            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";

        }

        //public IWebDriver getDriver()
        //{
        //    return driver;
        //}

         public void InitBrowser(String browserName)
         {
             switch (browserName)
             {
                 case "Chrome":
                     new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                     driver = new ChromeDriver();
                    // return driver;
                     break;

               case "Firefox":

                     new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                     driver = new FirefoxDriver();
                     break;

                 case "Edge":

                     //new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                     driver = new EdgeDriver();
                     break;
             }

         }

        [TearDown]
        public void CloseBrowser()
        {
           // Thread.Sleep(60);
            //driver.Close();

        }
    }
}
