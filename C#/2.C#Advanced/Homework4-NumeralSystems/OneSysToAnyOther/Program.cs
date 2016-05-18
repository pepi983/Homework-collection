using System;
using System.Numerics;

namespace domashnobroini
{
    class Program
    {
        static void dectohex(BigInteger numberInDecimal, int outputNumSys, bool sign)
        {

            string result = "";
            while (numberInDecimal > 0)
            {
                if (numberInDecimal % outputNumSys > 9 && outputNumSys > 10)
                {

                    BigInteger remainder = numberInDecimal % outputNumSys;

                    if (remainder == 10) result = result + 'A';
                    else if (remainder == 11) result = result + 'B';
                    else if (remainder == 12) result = result + 'C';
                    else if (remainder == 13) result = result + 'D';
                    else if (remainder == 14) result = result + 'E';
                    else if (remainder == 15) result = result + 'F';


                }
                else
                {
                    result += numberInDecimal % outputNumSys;
                }
                numberInDecimal = numberInDecimal / outputNumSys;
            }

            var res = result.ToCharArray();

            Array.Reverse(res);
            if (sign == false) Console.Write('-');


            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i]);
            }



        }
        static void Main(string[] args)
        {
            bool sign = true;
            int initialNumSys = int.Parse(Console.ReadLine());
            string number = (Console.ReadLine());
            int outputNumSys = int.Parse(Console.ReadLine());
            BigInteger sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == '-' && i == 0) { sign = false; number = number.Trim(new Char[] { '-' }); i = -1; continue; }
                if (char.IsDigit(number[i]))
                    sum = sum + (number[i] - '0') * (BigInteger)(BigInteger.Pow(initialNumSys, (number.Length - i - 1)));
                else { sum = sum + ((number[i] - 'A') + 10) * (BigInteger)(BigInteger.Pow(initialNumSys, (number.Length - i - 1))); }
            }

            dectohex(sum, outputNumSys, sign);
        }
    }
}
