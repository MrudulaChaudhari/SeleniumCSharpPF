using CSharpSelFrameworkWithPageFactory.pageObjects;
using CSharpSelFrameworkWithPageFactory.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSelFrameworkWithPageFactory
{
    internal class EndToEndDataDriven : Base
    {
        [Test]
        [TestCase("rahulshettyacademy", "learning")]
       /* [TestCase("rahuls", "learning")]
        [TestCase("rahulshettyacademy", "learng")]
        [TestCase("Mrudula", "ABC")]
        [TestCase("123", "123")]*/

        public void EndToEndFLowWithData(String username, String password)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            LoginPage loginPage = new LoginPage(driver);  // creating object of LoginPage class to read the locators/objects

            loginPage.getUserName().SendKeys(username);

            IWebElement pswd = driver.FindElement(By.Name("password"));
            pswd.SendKeys(password);
            driver.FindElement(By.XPath("//input[@value='Sign In']")).Click();
            Thread.Sleep(60);

            String title = driver.Title;
         
            TestContext.Progress.WriteLine(title);

            Assert.That(title, Is.EqualTo("ProtoCommerce"));


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
