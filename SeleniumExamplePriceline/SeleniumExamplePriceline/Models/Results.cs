using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExamplePriceline.Helpers;
using System.Windows.Forms;
using OpenQA.Selenium.Support.UI;

namespace SeleniumExamplePriceline.Models
{
    public class Results
    {
        //Instance variables
        private static By NonStopChxBox = By.CssSelector("input[name='nonstop']");
        private static By MultiStopsChxBx = By.XPath("//*[@id='root']/div/div/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/button[2]");
        private static By ClearCarriersLnk = By.CssSelector("span[ng-click='noneAction()']");
        private static By ClearCarriersLnk2 = By.XPath("//*[@id='root']/div/div/div[2]/div[1]/div[1]/div[4]/div[1]/div[2]/button[2]");
        private static By SelectDeltaChxBox = By.CssSelector("input[name='DL']");
        private static By SelectDeltaChxBox2 = By.XPath("//*[@id='root']/div/div/div[2]/div[1]/div[1]/div[4]/div[2]/label[3]/div/div[1]/div/svg[2]");
        private static By FlightPrices = By.CssSelector("span[data-test='regular-dollars']");
        

        //No-args constructor
        public Results()
        {

        }

        /// <summary>
        /// Method to switch to the browser tab showing search results
        /// </summary>
        public static void SwitchToResultsTab()
        {
            Common.webDriver.SwitchTo().Window(Common.webDriver.WindowHandles[1]);
        }

        /// <summary>
        /// Method to alter results filters to only show one-stop flights on Delta
        /// Also writes the selected fare to file
        /// </summary>
        public static void FilterResultsAndSelectFlight()
        {
            //Common.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(NonStopChxBox));
            //Common.webDriver.FindElement(NonStopChxBox).Click();
            //Common.Wait(1000);
            //Common.webDriver.FindElement(MultiStopsChxBx).Click();
            //Common.Wait(1000);
            try
            {
                Common.webDriver.FindElement(ClearCarriersLnk).Click();
            }
            catch(Exception e)
            {
                Common.webDriver.FindElement(ClearCarriersLnk2).Click();
            }
            Common.Wait(1000);
            try
            {
                Common.webDriver.FindElement(SelectDeltaChxBox).Click();
            }
            catch(Exception e)
            {
                Common.webDriver.FindElement(SelectDeltaChxBox2).Click();
            }
            
            Common.Wait(3000);
            int count = Common.webDriver.FindElements(FlightPrices).Count;
            Common.writer.WriteLine(Common.webDriver.FindElements(FlightPrices).ElementAt(count - 1).Text);
            Common.webDriver.FindElements(FlightPrices).ElementAt(count - 1).Click();
        }
    }
}
