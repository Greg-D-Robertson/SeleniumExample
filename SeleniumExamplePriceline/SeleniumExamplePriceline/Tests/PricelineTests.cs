using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using SeleniumExamplePriceline.Models;
using System.Windows.Forms;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;
using SeleniumExamplePriceline.Helpers;
using OpenQA.Selenium.Support.Events;
using System.IO;

namespace SeleniumExamplePriceline.Tests
{
    public class PricelineTests
    {
        private readonly string URL = "http://www.priceline.com/";
        

        [SetUp]
        public void Setup()
        {
            Common.webDriver.Manage().Window.Maximize();
            Common.webDriver.Navigate().GoToUrl(URL);

        }

        [TearDown]
        public void Teardown()
        {
            //driver.Close();
            Common.writer.Close();
        }

        [Test]
        public void FindFlight()
        {
            //Navigate to www.priceline.com, click Flights tab, enter flight information and click to search
            Home.NavToFlightsTab();
            Home.EnterFlightInfoAndSearch();

            //Switch to the results tab, filter out results for one-stop flights on Delta, then click on the most expensive flight on the screen
            Results.SwitchToResultsTab();
            Results.FilterResultsAndSelectFlight();

            //Switch to the details tab, write the fight numbers to file, take and save a screenshot
            Details.SwitchToDetailsTab();
            Details.WriteFlightNumsToFile();
            Details.GetScreenshot();

            
        }
    }
}
