using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstConsoleApp
{
    public class ChristmasCountDown
    {
        public void DaysToChristmas()
        {
            // Current Date
            DateTime today = DateTime.Today;

            // Year for Christmas (This year or next)
            int year = today.Month > 12 || (today.Month == 12 && today.Day > 25) ? today.Year + 1 : today.Year;

            // Christmas Day for current or next year
            DateTime christmas = new DateTime(year, 12, 25);

            // Calculate the time difference between today and Christmas
            TimeSpan timeUntilChristmas = christmas - today;

            // Output the countdown
            Console.WriteLine($"Time until Christmas: {timeUntilChristmas.Days} days");
        }
    }
}
