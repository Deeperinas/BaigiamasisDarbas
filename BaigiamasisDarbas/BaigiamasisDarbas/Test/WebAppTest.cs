using BaigiamasisDarbas.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas.Test
{
    class WebAppTest : BaseTest
    {
        [Test] 
        public static void TestDeclineAgreements()
        {
            webAppPage.NavigateToPage();
            webAppPage.AcceptCookies();
            webAppPage.Login();
            webAppPage.DeclineAgreements();
        }

        [Test]
        public static void TestColorPalettes()
        {
            webAppPage.NavigateToPage();
            webAppPage.AcceptCookies();
            webAppPage.LoginDemoUser();
            webAppPage.SelectScan();
            webAppPage.ChangeColorPalette();
            webAppPage.VerifyPaletteWorks();
        }
        





    }
}

