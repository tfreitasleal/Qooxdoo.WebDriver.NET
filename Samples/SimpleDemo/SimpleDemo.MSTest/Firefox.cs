﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Wisej.Qooxdoo.WebDriver;

namespace SimpleDemo.MSTest
{
    [TestClass]
    public class Firefox
    {
        private static IWebDriver _internalWebDriver;

        public static QxWebDriver Driver;

        [ClassInitialize]
        public static void Setup(TestContext testContext)
        {
            _internalWebDriver = new FirefoxDriver();
            Driver = new QxWebDriver(_internalWebDriver);
        }

        [ClassCleanup]
        public static void TearDown()
        {
            _internalWebDriver.Quit();
            _internalWebDriver.Dispose();
            Driver.Quit();
            Driver.Dispose();
        }

#if !DEBUGJS
        [TestMethod]
        public void F_A01_ClickSearch()
        {
            Driver.Url = "http://www.qooxdoo.org/current/api/index.html";
            ApiViewerTests.A01_ClickSearch(Driver);
        }

        [TestMethod]
        public void F_A02_ClickLegend()
        {
            ApiViewerTests.A02_ClickLegend(Driver);
        }

        [TestMethod]
        public void F_A03_ClickContent()
        {
            ApiViewerTests.A03_ClickContent(Driver);
        }

        [TestMethod]
        public void F_A04_ClickTreeItem()
        {
            ApiViewerTests.A04_ClickTreeItem(Driver);
        }
#endif

        [TestMethod]
        public void F_F01_AskQuitNo()
        {
#if !DEBUGJS
            Driver.Url = "http://localhost:16461/Default.html";
#else
            Driver.Url = "http://localhost:16461/Debug.html";
#endif
            ExpectedConditions.TitleIs("Main Page");
            FirstRound.F01_AskQuitNo(Driver);
        }

        [TestMethod]
        public void F_F02_MainPage_customerEditor_Click()
        {
            FirstRound.F02_MainPage_customerEditor_Click(Driver);
        }

        [TestMethod]
        public void F_F03_ButtonsWindow_customerEditor_Click()
        {
            FirstRound.F03_ButtonsWindow_customerEditor_Click(Driver);
        }

        [TestMethod]
        public void F_F04_CustomerEditor_customerEditor_LabelContents()
        {
            FirstRound.F04_CustomerEditor_customerEditor_LabelContents(Driver);
        }

        [TestMethod]
        public void F_F05_CloseWindow()
        {
            FirstRound.F05_CloseWindow(Driver);
        }

        [TestMethod]
        public void F_F06_MainPage_customerEditor_Click()
        {
            FirstRound.F06_MainPage_customerEditor_Click(Driver);
        }

        [TestMethod]
        public void F_F07_ButtonsWindow_customerEditor_Click()
        {
            FirstRound.F07_ButtonsWindow_customerEditor_Click(Driver);
        }

        [TestMethod]
        public void F_F08_CustomerEditor_customerEditor_LabelContents()
        {
            FirstRound.F08_CustomerEditor_customerEditor_LabelContents(Driver);
        }

        [TestMethod]
        public void F_F09_CloseWindow()
        {
            FirstRound.F09_CloseWindow(Driver);
        }

        [TestMethod]
        public void F_F10_AskQuitYes()
        {
            FirstRound.F10_AskQuitYes(Driver);
        }
    }
}