using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;

namespace WinAppDriverSeleniumAutomation
{
    class DepricatedWinAppAutomation
    {

        private const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
        private const string CalculatorAppId = "C:\\Users\\ChandrakalaG\\AppData\\Local\\SourceTree\\SourceTree.exe";

        protected static WindowsDriver<WindowsElement> session;

        public static void Setup(TestContext context)
        {
            // Launch Calculator application if it is not yet launched
            if (session == null)
            {
                /*// Create a new session to bring up an instance of the Calculator application
                
                DesiredCapabilities appCapabilities = new DesiredCapabilities();
                appCapabilities.SetCapability("app", "C:\\Users\\ChandrakalaG\\AppData\\Local\\SourceTree\\SourceTree.exe");
                appCapabilities.SetCapability("deviceName", "WindowsPC");
                session = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appCapabilities);
                Assert.IsNotNull(session);

               
                session.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1.5);*/
            }
        }

        public static void TearDown()
        {
            
            if (session != null)
            {
                session.Quit();
                session = null;
            }
        }
    }
}

