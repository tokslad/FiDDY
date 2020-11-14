using FiddlePractice.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiddlePractice.PageObject
{
    class FiddleNetPage
    {
        IWebDriver driver;
        public FiddleNetPage()
        {
            driver = Hooks1.driver;
        }


        IWebElement gettingStarted => driver.FindElement(By.XPath("//a[@href='/GettingStarted/']"));
        IWebElement backEditor => driver.FindElement(By.XPath("(//a[@class='btn btn-default'])[1]"));
        IWebElement helloWorld => driver.FindElement(By.XPath("//*[@id='output']"));

        public void naviagteToUrl(String url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void IClickOnGettingStarted()
        {
            gettingStarted.Click();
        }

        public void IClickOnBackEditor()
        {
            backEditor.Click();
        }

        public bool IsHelloWorldDisplayed()
        {
            return helloWorld.Displayed;
        }
    }

    













}
