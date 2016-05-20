using System;

namespace LeapYear
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            bool isleap = DateTime.IsLeapYear(year);
            if (isleap)
            {
                Console.WriteLine("Leap");
            }
            else
            {

                Console.WriteLine("Common");
            }

        }
    }
}
