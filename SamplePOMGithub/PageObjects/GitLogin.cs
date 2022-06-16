using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;


namespace SamplePOMGithub.PageObjects
{
    public class GitLogin:BasePage
    {
        public GitLogin(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/main/div/div[4]/form/div/input[12]")]
        private IWebElement logincheck;
        
        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/main/div/div[4]/form/label")]
        private IWebElement username;


        public string GetUsernameCorrect()
        {
            logincheck.Click();
            Thread.Sleep(2000);
            string txt = username.Text;
            return txt;
        }
    }
}
