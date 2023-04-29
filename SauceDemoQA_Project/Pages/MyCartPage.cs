using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoQA_Project.Pages
{
    public class MyCartPage : BasePage
    {
        public MyCartPage(IWebDriver driver) : base(driver)
        {
        }

        public void ClickMyCartPage()
        {
            driver.FindElement(By.CssSelector(".shopping_cart_badge")).Click();
        }
    }
}
