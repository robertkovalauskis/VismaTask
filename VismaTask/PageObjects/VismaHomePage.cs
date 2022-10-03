using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VismaTask.PageObjects
{
    internal class VismaHomePage
    {
        private IWebDriver driver;

        public VismaHomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "onetrust-accept-btn-handler")]
        private IWebElement acceptCookiesBtn;

        [FindsBy(How = How.XPath, Using = "//*[text()='Vakances']")]
        private IWebElement vacanciesBtn;

        public void OpenVismaHomePage()
        {
            driver.Navigate().GoToUrl("https://www.visma.lv/");
        }

        public void AcceptCookies()
        {
            acceptCookiesBtn.Click();
        }

        public void ClickOnVacanciesBtn()
        {
            vacanciesBtn.Click();
        }
    }
}
