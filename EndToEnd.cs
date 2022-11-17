using CSharpSelFramework.Utilities;
using CSharpSelFrameworkWithPageFactory.pageObjects;
using CSharpSelFrameworkWithPageFactory.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSelFrameworkWithPageFactory
{
    public class EndToEnd : Base
    {
        [Test]
        public void EndToEndFLow()
        {

            LoginPage loginPage = new LoginPage(driver);  // creating object of LoginPage class to read the locators/objects

            loginPage.getUserName().SendKeys("rahulshettyacademy");

            IWebElement pswd = driver.FindElement(By.Name("password"));
            pswd.SendKeys("learning");
            driver.FindElement(By.XPath("//input[@value='Sign In']")).Click();

            String title = driver.Title;

            //Assert.That(title, Is.EqualTo("ProtoCommerce"));


            IList<IWebElement> products = driver.FindElements(By.TagName("app-card"));

            TestContext.Progress.WriteLine(" Count is : " + products.Count);

            foreach (IWebElement product in products)
            {

                TestContext.Progress.WriteLine("Name of The product : " + product.FindElement(By.CssSelector(".card-title a")).Text);



                //TestContext.Progress.WriteLine("The Product is :" + product);
            }








        }


    }
}
