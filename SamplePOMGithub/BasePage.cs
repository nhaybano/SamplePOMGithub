using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SamplePOMGithub
{
    public class BasePage
    {
        public IWebDriver driver;
        public void intialize() {
            System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"C:\Users\nates\OneDrive\Desktop\Sele\chromedriver_win32");
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://github.com/login");
        }
        public void close()
        {
            driver.Quit();
        }
    }
}
