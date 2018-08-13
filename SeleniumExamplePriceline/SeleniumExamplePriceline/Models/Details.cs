using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExamplePriceline.Helpers;

namespace SeleniumExamplePriceline.Models
{
    public class Details
    {
        //Instance variables
        private static By FlightNums = By.ClassName("sc-cmTdod gQuDVd");

        //No-args constructor
        public Details()
        {

        }

        /// <summary>
        /// Method to switch to browser tab showing selected flight details
        /// </summary>
        public static void SwitchToDetailsTab()
        {
            Common.webDriver.SwitchTo().Window(Common.webDriver.WindowHandles[2]);
        }

        /// <summary>
        /// Method to write flight numbers to file
        /// </summary>
        public static void WriteFlightNumsToFile()
        {
            foreach (IWebElement element in Common.webDriver.FindElements(FlightNums))
            {
                Common.writer.WriteLine(element.Text);
            }
        }

        /// <summary>
        /// Method to take screen shot and save to file
        /// </summary>
        public static void GetScreenshot()
        {
            Screenshot ss = ((ITakesScreenshot)Common.webDriver).GetScreenshot();
            ss.SaveAsFile(@"C: \Users\greg_\Documents\Selenium\SeleniumExamplePriceline\SeleniumExamplePriceline\Files", ScreenshotImageFormat.Png);
        }
    }
}
