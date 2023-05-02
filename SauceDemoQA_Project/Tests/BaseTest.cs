using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SauceDemoQA_Project.Pages;
using SauceDemoQA_Project.Utils;

namespace SauceDemoQA_Project.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;
        protected HomePage homePage;
        protected LoginPage loginPage;
        protected ProductPage productPage;
        protected AddToCartPage addToCardPage;
        protected MyCartPage myCartPage;
        protected CheckOutPage checkOutPage;
        protected FinishPage finishPage;

        [SetUp]
        public void CreateObjects()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(Constants.Url);
            Thread.Sleep(2000);
            this.homePage = new HomePage(driver);
            this.loginPage = new LoginPage(driver);
            this.productPage = new ProductPage(driver);
            this.addToCardPage = new AddToCartPage(driver);
            this.myCartPage = new MyCartPage(driver);
            this.checkOutPage = new CheckOutPage(driver);
            this.finishPage = new FinishPage(driver);   
        }

        [TearDown]
        public void CloseDriver()
        {
            Thread.Sleep(2000);
            driver.Quit();
        }

        [Test]
        public void GoToUrl()
        {
        }

        [Test]
        public void LoginTest()
        {
            loginPage.Login();
        }

        [Test]
        public void SelectProductTest()
        {
            loginPage.Login();
            homePage.ClickOnFirstProduct();
            homePage.Wait(4);
            productPage.ClickBackToHome();  
        }

        [Test]
        public void EndToEndTest()
        {
            loginPage.Login();
            loginPage.Wait(1);
            homePage.ClickOnFirstProduct();
            homePage.Wait(1);
            addToCardPage.AddToCard();
            myCartPage.ClickMyCartPage();
            myCartPage.Wait(1);
            checkOutPage.PressCheckOutButton();
            checkOutPage.Wait(1);
            checkOutPage.InsertCheOutInformation();
            finishPage.ClickFinshPage();
            homePage.Wait(4);

            string expectedMessage = Constants.ThankYouMessage;
            string actualMessage = finishPage.GetThankYouMessage();
            Assert.That(expectedMessage, Is.EqualTo(actualMessage));
        }
    }
}