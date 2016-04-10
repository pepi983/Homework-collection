using System;

namespace Age
{
    class Age
    {
        static void Main()
        {
            String Birthday = Console.ReadLine();
            DateTime date = DateTime.ParseExact(Birthday, "MM.dd.yyyy", null);
            DateTime now = DateTime.Now;
            int year = date.Year;
            int month = date.Month;
            int day = date.Day;
            int year1 = now.Year;
            int month1 = now.Month;
            int day1 = now.Day;
            int result = year * 10000 + month * 100 + day;
            int result1 = year1 * 10000 + month1 * 100 + day1;
            Console.WriteLine((result1 - result) / 10000);
            Console.WriteLine(((result1 - result) / 10000) + 10);

        }
    }
}
