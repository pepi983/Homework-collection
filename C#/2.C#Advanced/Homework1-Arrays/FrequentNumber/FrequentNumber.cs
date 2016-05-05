using System;

namespace FrequentNumber
{
    class FrequentNumber
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            int counter = 0;
            int MaxCounter = 0;
            int LastMember = 0;
            int Frequent = 0;
            bool isFirst = true;
            for (int i = 0; i < N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());         
            }
            Array.Sort(numbers);
            for (int k = 0; k < N; k++)
            {
                if (isFirst)
                {
                    isFirst = false;
                    counter++;
                    LastMember = numbers[k];
                    Frequent = numbers[k];
                    if (counter > MaxCounter)
                    {
                        MaxCounter = counter;
                    }
                }
                else
                {
                    if (numbers[k] != LastMember)
                    {
                        if (counter > MaxCounter)
                        {
                            MaxCounter = counter;
                            Frequent = numbers[k];
                        }
                        counter = 1;
                        LastMember = numbers[k];

                    }
                    else
                    {
                        counter++;
                        LastMember = numbers[k];
                        if (counter > MaxCounter)
                        {
                            MaxCounter = counter;
                            Frequent = numbers[k];
                        }
                    }
                }
            }
            Console.WriteLine("{0} ({1} times)", Frequent, MaxCounter);
        }
    }
}
