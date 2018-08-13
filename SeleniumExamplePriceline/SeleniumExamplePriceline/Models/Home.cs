using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExamplePriceline.Helpers;
using System.Windows.Forms;

namespace SeleniumExamplePriceline.Models
{
    public class Home
    {
        //Instance variables
        private static By FlightsTab = By.CssSelector("button[data-autobot-element-id='DASH_TAB_FLIGHTS'");
        private static By WhereFrom = By.CssSelector("input.Input.Input--pristine.Input--valid.mobile-seti[placeholder='Where from?']");
        private static By WhereTo = By.CssSelector("input.Input.Input--pristine.Input--valid.mobile-seti[placeholder='Where to?']");
        private static By DepartDate = By.CssSelector("input.Input.Input--pristine.Input--valid.mobile-seti[placeholder='Departing']");
        private static By ReturnDate = By.CssSelector("input.Input.Input--pristine.Input--valid.mobile-seti[placeholder='Returning']");
        private static By NumTravelers = By.CssSelector("span.traveler-selection__input__display");
        private static By FindDealBtn = By.CssSelector("button.desktop.primary.green.mobile-seti");

        //No-args Constructor
        public Home()
        {

        }

        /// <summary>
        /// Method to click on the Flights tab on the priceline home page
        /// </summary>
        public static void NavToFlightsTab()
        {
            Common.webDriver.FindElement(FlightsTab).Click();
        }

        /// <summary>
        /// Method that enters flight information into the Flights tab and clicks to search
        /// </summary>
        public static void EnterFlightInfoAndSearch()
        {
            Common.webDriver.FindElements(WhereFrom)[2].Click();
            Common.webDriver.FindElements(WhereFrom)[2].SendKeys("San Francisco, CA - San Francisco Intl Airport (SFO)");
            Common.Wait(1000);
            SendKeys.SendWait("{TAB}");
            Common.webDriver.FindElements(WhereTo)[1].SendKeys("New York City, NY - All Airports (NYC)");
            Common.Wait(1000);
            SendKeys.SendWait("{TAB}");
            Common.webDriver.FindElements(DepartDate)[1].SendKeys("08/15/2018");
            Common.Wait(1000);
            SendKeys.SendWait("{TAB}");
            Common.webDriver.FindElements(ReturnDate)[1].SendKeys("08/31/2018");
            Common.Wait(1000);
            SendKeys.SendWait("{TAB}");
            SendKeys.SendWait("{TAB}");
            Common.webDriver.FindElement(FindDealBtn).Click();
            Common.Wait(15000);
        }
    }
}
