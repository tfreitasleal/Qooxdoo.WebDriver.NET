﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Wisej.Qooxdoo.WebDriver;

namespace SimpleDemo.NUnit
{
    [TestFixture]
    [Parallelizable(ParallelScope.None)]
    public class FirefoxWisej
    {
        private static IWebDriver _internalWebDriver;

        public static QxWebDriver Driver;

        [OneTimeSetUp]
        public void Setup()
        {
            _internalWebDriver = new FirefoxDriver();
            Driver = new QxWebDriver(_internalWebDriver);
#if !DEBUGJS
            Driver.Url = "http://localhost:16461/Default.html";
#else
            Driver.Url = "http://localhost:16461/Debug.html";
#endif
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _internalWebDriver.Quit();
            _internalWebDriver.Dispose();
            Driver.Quit();
            Driver.Dispose();
        }

        [Test]
        [Order(3050)]
        public void F01_AskQuitNo()
        {
            ExpectedConditions.TitleIs("Main Page");
            FirstRound.F01_AskQuitNo(Driver);
        }

        [Test]
        [Order(3060)]
        public void F02_MainPage_customerEditor_Click()
        {
            FirstRound.F02_MainPage_customerEditor_Click(Driver);
        }

        [Test]
        [Order(3070)]
        public void F03_ButtonsWindow_customerEditor_Click()
        {
            FirstRound.F03_ButtonsWindow_customerEditor_Click(Driver);
        }

        [Test]
        [Order(3080)]
        public void F04_CustomerEditor_customerEditor_LabelContents()
        {
            FirstRound.F04_CustomerEditor_customerEditor_LabelContents(Driver);
        }

        [Test]
        [Order(3090)]
        public void F05_CloseWindow()
        {
            FirstRound.F05_CloseWindow(Driver);
        }

        [Test]
        [Order(3100)]
        public void F06_MainPage_customerEditor_Click()
        {
            FirstRound.F06_MainPage_customerEditor_Click(Driver);
        }

        [Test]
        [Order(3110)]
        public void F07_ButtonsWindow_customerEditor_Click()
        {
            FirstRound.F07_ButtonsWindow_customerEditor_Click(Driver);
        }

        [Test]
        [Order(3120)]
        public void F08_CustomerEditor_customerEditor_LabelContents()
        {
            FirstRound.F08_CustomerEditor_customerEditor_LabelContents(Driver);
        }

        [Test]
        [Order(3130)]
        public void F09_CloseWindow()
        {
            FirstRound.F09_CloseWindow(Driver);
        }

        [Test]
        [Order(3140)]
        public void F10_AskQuitYes()
        {
            FirstRound.F10_AskQuitYes(Driver);
        }
    }
}