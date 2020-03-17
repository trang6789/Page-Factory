using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticePageFacstory.PagesObjects
{
    class AboutPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public AboutPage(IWebDriver driver)
        {
            this.driver = driver;
            //wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//*[@id = 'menu-main']//descendant::a[@title = 'Search']")]
        //[FindsBy(How = How.XPath, Using = "//*[@class = 'fusion-custom-menu-item fusion-main-menu-search']//descendant::a")]
        private IWebElement firstsearch;

        //[FindsBy(How = How.CssSelector, Using = "#sidebar input[class='s']")]
        [FindsBy(How = How.XPath, Using = "//*[@aria-label='Main Menu Mobile']//preceding::input[@class = 's']")]
        private IWebElement searchText;

        [FindsBy(How = How.XPath, Using = "//*[@aria-label= 'Main Menu Mobile']//preceding::input[@type = 'submit']")]
        private IWebElement secondsearch;

        public ResultPage search(string text)
        {
            firstsearch.Click();
            searchText.SendKeys(text);
            
            Thread.Sleep(2000);
            //wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#sidebar .searchsubmit"))).Click();
            secondsearch.Click();
            return new ResultPage(driver);
        }
    }
}
