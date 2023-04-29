using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoQA_Project.Pages
{
    public class CheckOutPage : BasePage
    {
        public CheckOutPage(IWebDriver driver) : base(driver)
        {
        }

        public void PressCheckOutButton()
        {
            driver.FindElement(By.CssSelector("#checkout")).Click();
        }

        public void InsertCheOutInformation()
        {
            driver.FindElement(By.CssSelector("#first-name")).SendKeys("Popescu");
            driver.FindElement(By.CssSelector("#last-name")).SendKeys("Andy");
            driver.FindElement(By.CssSelector("#postal-code")).SendKeys("9500");
            driver.FindElement(By.CssSelector("#continue")).Click();
        }
    }
}
