using OpenQA.Selenium;
using SauceDemoQA_Project.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoQA_Project.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public void Login()
        {
            driver.FindElement(By.CssSelector("#user-name")).SendKeys(Constants.UserName);
            driver.FindElement(By.CssSelector("#password")).SendKeys(Constants.Password);
            driver.FindElement(By.CssSelector("#login-button")).Click();
        }
    }
}
