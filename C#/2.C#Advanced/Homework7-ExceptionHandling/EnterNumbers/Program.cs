using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kurec = true;
            int[] huinq = new int[10];
            for (int i = 0; i < 10; i++)
            {
                huinq[i] = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    if (huinq[i] < 1)
                    {
                        kurec = false;
                        break;
                    }
                }
                else if (huinq[i] < huinq[i-1])
                {
                    kurec = false;
                    break;
                }
                else if (i == 9)
                {
                    if (huinq[i] > 100)
                    {
                        kurec = false;
                        break;
                    }
                }
            }
            if (kurec)
            {
                Console.WriteLine(string.Join(" < ", huinq));
            }
            else
            {
                Console.WriteLine("Exception");
            }
        }
    }
}

