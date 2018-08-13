using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.IO;

namespace SeleniumExamplePriceline.Helpers
{
    public class Common
    {
        public static IWebDriver webDriver = new ChromeDriver(@"C:\Users\greg_\Documents\Selenium\SeleniumExamplePriceline\SeleniumExamplePriceline\Drivers");
        public static StreamWriter writer = File.CreateText(@"C: \Users\greg_\Documents\Selenium\SeleniumExamplePriceline\SeleniumExamplePriceline\Files\FlightNumbers.txt");
        public static WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));

        public static void Wait(int time)
        {
            int WaitTime = 0;
            Stopwatch watch = new Stopwatch();
            watch.Start();
            while(watch.ElapsedMilliseconds < time)
            {
                WaitTime++;
            }
            watch.Stop();
        }

    }
}
