using System;

namespace MaximalSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            int counter = 0;
            int maxCounter = 0;
            int lastMember = 0;
            bool isFirst = true;
            for (int i = 0; i < N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                if (isFirst)
                {

                    isFirst = false;
                    lastMember = numbers[i];
                    counter++;
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                    }
                }
                else
                {
                    if (numbers[i] <= lastMember)
                    {
                        if (counter > maxCounter)
                        {
                            maxCounter = counter;
                        }
                        counter = 0;
                        counter++;
                        lastMember = numbers[i];
                    }
                    else
                    {

                        counter++;
                        lastMember = numbers[i];
                        if (counter > maxCounter)
                        {
                            maxCounter = counter;
                        }
                    }
                }
            }
            Console.WriteLine(maxCounter);

        }
    }
}