using System;

namespace BitsToBits
{
    class BitsToBits
    {

        static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            int currOneCount = 0;
            int currZeroCount = 0;

            int maxOneCount = 0;
            int maxZeroCount = 0;

            int LastBit = 5;

            for (int i = 0; i < n; i++)
            {
        

                int num = int.Parse(Console.ReadLine());
                for (int j = 29; j >= 0; j--)
                {
                    int bit = ((1 << j) & num) >> j;
                    if (bit == 1)
                    {
                        if (LastBit == 1)
                        {
                            currOneCount++;
                        }
                        else
                        {
                            maxZeroCount = Math.Max(maxZeroCount, currZeroCount);
                            currZeroCount = 0;
                            currOneCount = 1;
                        }
                    }
                    else
                    {
                        if (LastBit == 0)
                        {
                            currZeroCount++;
                        }
                        else
                        {
                            maxOneCount = Math.Max(maxOneCount, currOneCount);
                            currOneCount = 0;
                            currZeroCount = 1;
                        }
                    }
                    LastBit = bit;
                }
            }
            maxZeroCount = Math.Max(maxZeroCount, currZeroCount);
            maxOneCount = Math.Max(maxOneCount, currOneCount);

            Console.WriteLine(maxZeroCount);
            Console.WriteLine(maxOneCount);
          
        }
    
    }

}
