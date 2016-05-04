using System;

namespace CompareArrays
{
    class CompareArrays
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] Arr = new int[N];
            int[] Arr1 = new int[N];
            bool ifEqual = true;
            for (int i = 0; i < N; i++)
            {
                Arr[i] = int.Parse(Console.ReadLine());
            }
            for (int l = 0; l < N; l++)
            {
                Arr1[l] = int.Parse(Console.ReadLine());
            }
            for (int k = 0; k < N; k++)
            {
                if (Arr[k] == Arr1[k])
                {
                    continue;
                }
                else
                {
                    ifEqual = false;
                    break;
                }
            }

            if (ifEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}
