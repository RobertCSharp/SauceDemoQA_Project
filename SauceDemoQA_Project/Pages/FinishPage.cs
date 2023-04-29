﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoQA_Project.Pages
{
    public class FinishPage : BasePage
    {
        public FinishPage(IWebDriver driver) : base(driver)
        {
        }

        public void ClickFinshPage()
        {
            driver.FindElement(By.CssSelector("#finish")).Click();
        }
    }
}
