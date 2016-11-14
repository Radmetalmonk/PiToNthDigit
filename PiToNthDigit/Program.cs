using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiToNthDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            // Use PI = 4.0 * arctan(1.0)
            // Limited to 14 decimal places
            PiToNthDigit p = new PiToNthDigit();
            Console.WriteLine("Enter number of digits of pi to display (after the decimal)\n using pi = 4.0 * arctan(1.0)");
            n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(p.GetPiToNthDigit(n).ToString());

            // Use Machin's formula
            // Limited to 14 decimal places
            Console.WriteLine("Enter number of digits of pi to display (after the decimal)\n using Machin's formula");
            n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(p.GetPiToNthDigitMachins(n).ToString());

            // Caculate with a list to allow for more digits
            // Digits are incorrect after 15 digits
            Console.WriteLine("Enter number of digits of pi to display (after the decimal)\n using a list of machin's formula digits (note: inaccurate after 15)");
            n = Convert.ToInt16(Console.ReadLine());
            List<string> piList = p.GetPiToNthDigitList(n);
            foreach(string s in piList)
            {
                Console.Write(s);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
