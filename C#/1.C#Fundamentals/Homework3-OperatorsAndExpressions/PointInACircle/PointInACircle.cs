using System;
class BookExperience
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double distance = Math.Sqrt((x * x) + (y * y));
        string hui = "yes ";
        string hui1 = "no ";
        if (distance <= 2.0)
        {
            Console.WriteLine(hui + "{0:F2}", distance);
        }
        else
        {
            Console.WriteLine(hui1 + "{0:F2}", distance);
        }
    }
}