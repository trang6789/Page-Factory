using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePageFacstory.PagesObjects
{
    class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@class= 'fusion-main-menu']//descendant::span[@class='menu-text' and contains(text(),'About')]")]
        private IWebElement about;

        [FindsBy(How = How.ClassName, Using = "fusion-main-menu-icon")]
        private IWebElement searchIcon;

        public void goToPage()
        {
            driver.Navigate().GoToUrl("https://www.swtestacademy.com/");
        }

        public AboutPage goToAboutPage()
        {
            about.Click();
            return new AboutPage(driver);
        }
    }
}
