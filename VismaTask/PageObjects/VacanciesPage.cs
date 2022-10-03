using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VismaTask.PageObjects
{
    internal class VacanciesPage
    {
        private IWebDriver driver;

        public VacanciesPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "ul>li>a[aria-label='Quality Assurer']")]
        private IWebElement qualityAssurerBtn;

        public void ClickOnQualityAssurerVacancy()
        {
            qualityAssurerBtn.Click();
        }
    }
}
