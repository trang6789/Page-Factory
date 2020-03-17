using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PracticePageFacstory.PagesObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticePageFacstory
{
    class TestClass
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver("C:\\Users\\TNG77\\chromedriver_win32 (3)");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void SearchTextFromAboutPage()
        {
            HomePage home = new HomePage(driver);
            home.goToPage();
            AboutPage about = home.goToAboutPage();
            Thread.Sleep(3000);
            ResultPage result = about.search("selenium c#");
            Thread.Sleep(3000);
            result.clickOnFirstArticle();
            Thread.Sleep(3000);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
