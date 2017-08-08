using System;

namespace CSharpFundamentalsDatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToString());

            //DateTime.ToShortDateString no longer works but 
            //ToString("d") does the same thing. 
            Console.WriteLine(myValue.ToString("d"));

            Console.WriteLine(myValue.ToString("t"));

            Console.ReadLine();
        }
    }
}