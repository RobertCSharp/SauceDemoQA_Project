using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoQA_Project.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public void ClickOnFirstProduct()
        {
            driver.FindElement(By.CssSelector(".inventory_item_name:nth-child(1)")).Click();
        }
    }
}
