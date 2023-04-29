using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoQA_Project.Pages
{
    public class BasePage
    {
       protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickElement(IWebElement element)
        {
            element.Click();
        }

        public void SetText(IWebElement element, string text)
        {
            element.SendKeys(text);
        }

        public string GetText(IWebElement element)  => element.Text;

        public void Wait(int seconds)
        {
            seconds *= 1000;
            Thread.Sleep(seconds);
        }

    }

}
