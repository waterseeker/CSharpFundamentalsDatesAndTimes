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
            Console.WriteLine("using invaraint culture : " + myValue.ToString("D", CultureInfo.InvariantCulture));

            //formatting the time in a standard way according to current culture
            Console.WriteLine(myValue.ToString("T"));

            //same using invariant culture
            Console.WriteLine("using invaraint culture : " + myValue.ToString("T", CultureInfo.InvariantCulture));

            //display the date 3 days from now
            Console.WriteLine("The date three days from now will be " + myValue.AddDays(3).ToString("D"));

            //display the time seven hours from now
            Console.WriteLine("Seven hours from now, the time will be " + myValue.AddHours(7).ToString("T"));

            //display the date 42 days ago
            Console.WriteLine("Fourty-two days ago it was " + myValue.AddDays(-42).ToString("D") + ".");

            //display just the month number
            Console.WriteLine(myValue.Month.ToString());

            //assign a date to a DateTime and then do stuff with it
            DateTime birthdayOfBob = new DateTime(1969, 12, 7);
            Console.WriteLine("Bob's birthday was on " + birthdayOfBob.ToString("D") + "." + "\nThat was a " + birthdayOfBob.DayOfWeek + ".");


            DateTime firstDay = new DateTime(1, 1, 1);
            Console.WriteLine("The first day of the year 1 was a " + firstDay.DayOfWeek.ToString() + ".");

            //finding how much time has elapsed between two points in time
            DateTime birthdayOfLotsOfPeople = DateTime.Parse("12/13/13");
            TimeSpan lotsOfPeoplesAge = DateTime.Now.Subtract(birthdayOfLotsOfPeople);
            Console.WriteLine("It has been " + lotsOfPeoplesAge.TotalDays + " days since a lot of people were born.");

            Console.ReadLine();
        }
    }
}