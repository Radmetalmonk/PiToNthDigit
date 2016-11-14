using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiToNthDigit
{
    public class PiToNthDigit
    {
        // Limiter on number of digits to display
        private int _NLimit;

        // Default constructor sets limit
        public PiToNthDigit()
        {
            _NLimit = 100;
        }

        // Allow the user to set the limit
        public PiToNthDigit(int limit)
        {
            _NLimit = limit;
        }

        // Return double Pi to the Nth digit
        // Returns 0.0 if n > interal limit
        public double GetPiToNthDigit(int n)
        {
            // Calculate pi
            double pi = 4.0 * Math.Atan(1.0);

            // Check if n is within limit
            if (n > _NLimit)
            {
                return 0.0;
            }
            else
            {

                return pi - (pi % Math.Pow(10, -n));
            }
        }

        // Return double pi to the Nth digit
        // Uses Machin's Formula
        public double GetPiToNthDigitMachins(int n)
        {
            double pi;
            // Check if n is within limit
            if (n > _NLimit)
            {
                return 0.0;
            }
            else
            {
                pi = 16.0 * Math.Atan2(1.0,5.0) - 4.0 * Math.Atan2(1.0,239.0);
                return pi - (pi % Math.Pow(10, -n));
                
            }
        }

        // Calculate each digit, store in a list
        public List<string> GetPiToNthDigitList(int n)
        {
            // Counting variable
            int m = 0;
            double d;
            double pi = 16.0 * Math.Atan2(1.0, 5.0) - 4.0 * Math.Atan2(1.0, 239.0);

            // Initialize List
            List<string> piNums = new List<string>();

            // Add first couple of numbers
            piNums.Add("3");
            piNums.Add(".");
            
            // Trim each individual digit of pi
            while (m < n)
            {
                // Get rid of everything before the mth digit
                d = pi % Math.Pow(10, -m);
                // Get rid of everything after the mth digit
                d = Math.Truncate(d * Math.Pow(10, m+1));
                // Put it in the list
                piNums.Add(d.ToString());
                // Increment m; loop stops when m = n
                m++;
            }


            return piNums;
        }
    }
}
