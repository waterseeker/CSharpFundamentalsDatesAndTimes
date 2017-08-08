using System;
using System.Globalization;

namespace CSharpFundamentalsDatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToString());

            //DateTime.ToShortDateString no longer works but 
            //ToString("d") does the same thing
            //just shows the date
            Console.WriteLine(myValue.ToString("d"));

            //to just show the time
            Console.WriteLine(myValue.ToString("t"));

            //to format the datetime according to the current culture
            Console.WriteLine(myValue.ToString("D"));

            //same thing but with invariant culture
            Console.WriteLine(myValue.ToString("D", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}