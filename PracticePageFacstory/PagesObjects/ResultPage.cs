using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticePageFacstory.PagesObjects
{
    class ResultPage
    {
        private IWebDriver driver;

        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@class = 'fusion-link-wrapper']//following::a[contains(text(),'Selenium C# and NUnit Pain Free Start Guide')]")]
        private IWebElement firstArticle;

        public void clickOnFirstArticle()
        {
            firstArticle.Click();
            
        }
    }
}
