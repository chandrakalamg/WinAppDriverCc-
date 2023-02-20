using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;

namespace WinAppDriverSeleniumAutomation
{
    class SourcetreeWinAppAutomation
    {
        private static WindowsElement sourcetreeResult;
        protected static WindowsDriver<WindowsElement> sourcetreeSession;
        static void Main(string[] args)
        {
            WindowsDriver<WindowsElement> sourcetreeSession;
            AppiumOptions desiredCapabilities = new AppiumOptions();
            desiredCapabilities.AddAdditionalCapability("app", "C:\\Users\\ChandrakalaG\\AppData\\Local\\SourceTree\\SourceTree.exe");
            sourcetreeSession = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/"), desiredCapabilities);
            sourcetreeSession.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            sourcetreeResult = sourcetreeSession.FindElementByXPath("//*[@Name='Sourcetree']");
            Assert.IsNotNull(sourcetreeResult);


            Console.WriteLine("click on remote1");
            sourcetreeSession.FindElementByName("Remote").Click();

            Console.WriteLine("Click Edit accounts");
            sourcetreeSession.FindElementByName("Edit Accounts...").Click();
            Console.WriteLine(sourcetreeSession.FindElementByName("Options").Displayed);
        }

        public static void TearDown()
        {

            if (sourcetreeSession != null)
            {
                sourcetreeSession.Quit();
                sourcetreeSession = null;
            }
        }
/*
        //[TestMethod]
        //public void remote()
        //{

        //    Console.WriteLine("click on remote1");
        //    sourcetreeSession.FindElementByName("Remote").Click();

        //}
        //[TestMethod]
        //public void EditAccounts()
        //{
        //    Console.WriteLine("Click Edit accounts");
        //    sourcetreeSession.FindElementByName("Edit Accounts...").Click();
        //    Console.WriteLine(sourcetreeSession.FindElementByName("Options").Displayed);

        //}*/


    }
}
