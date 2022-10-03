using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using VismaTask.PageObjects;

namespace VismaTask
{
    [TestClass]
    public class Tests
    {
        private IWebDriver driver;
        By thankYouHeader = By.CssSelector("h1[data-test='applied-thanks']");
        By qualityAssurerVacancy = By.CssSelector("ul>li>a[aria-label='Quality Assurer']");

        [TestInitialize]
        public void TestInitialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [TestMethod]
        public void applyForAQualityAssurerVacancy()
        {
            VismaHomePage vhp = new VismaHomePage(driver);
            VacanciesPage vp = new VacanciesPage(driver);
            QualityAssurerPage qap = new QualityAssurerPage(driver);
            General g = new General(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(2000));

            vhp.OpenVismaHomePage();
            vhp.AcceptCookies();
            vhp.ClickOnVacanciesBtn();
            wait.Until(ExpectedConditions.ElementExists(qualityAssurerVacancy));
            vp.ClickOnQualityAssurerVacancy();
            qap.ClickOnApplyForJobBtn();
            qap.EnterFirstName();
            qap.EnterLastName();
            qap.EnterEmail();
            qap.SubmitApplication();

            Assert.IsFalse(g.IsElementPresent(thankYouHeader));

            g.TakeAScreenshot();

            driver.Close();
        }
    }
}
