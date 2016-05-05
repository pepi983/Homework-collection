using System;

namespace BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            bool occurence = false;
            int index = 0;
            for (int i = 0; i < N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int X = int.Parse(Console.ReadLine());
            for (int k = 0; k < N; k++)
            {
                if (numbers[k] == X)
                {
                    occurence = true;
                    index = k;
                    break;
                }
            }
            if (occurence)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("-1");
            }
        }
    }
}
