using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VismaTask.PageObjects
{
    internal class QualityAssurerPage
    {
        private IWebDriver driver;

        public QualityAssurerPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[text()='Apply for this job']")]
        private IWebElement applyForThisJobBtn;

        [FindsBy(How = How.Id, Using = "candidate_first_name")]
        private IWebElement firstNameField;

        [FindsBy(How = How.Id, Using = "candidate_last_name")]
        private IWebElement lastNameField;

        [FindsBy(How = How.Id, Using = "candidate_email")]
        private IWebElement emailField;

        [FindsBy(How = How.CssSelector, Using = "input[type='submit']")]
        private IWebElement submitApplicationBtn;

        public void ClickOnApplyForJobBtn()
        {
            applyForThisJobBtn.Click();
        }

        public void EnterFirstName()
        {
            firstNameField.SendKeys("Roberts");
        }

        public void EnterLastName()
        {
            lastNameField.SendKeys("Kovalauskis");
        }

        public void EnterEmail()
        {
            emailField.SendKeys("robert.kovalauskis@test.com");
        }

        public void SubmitApplication()
        {
            submitApplicationBtn.Click();
        }
    }
}
