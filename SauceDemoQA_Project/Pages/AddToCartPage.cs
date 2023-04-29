using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoQA_Project.Pages
{
    public class AddToCartPage : BasePage
    {
        public AddToCartPage(IWebDriver driver) : base(driver)
        {
        }

        public void AddToCard()
        {
            driver.FindElement(By.CssSelector("#add-to-cart-sauce-labs-backpack")).Click();
        }
    }
}
