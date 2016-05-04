using System;

public class CompareCharArrays
{
    public static void Main()
    {
        string arrA = Console.ReadLine();
        string arrB = Console.ReadLine();

        bool areEqual = true;
        string result = string.Empty;

        if (arrA.Length != arrB.Length)
        {
            areEqual = false;
            result = (arrA.Length < arrB.Length) ? "<" : ">";
        }
        else
        {
            for (int i = 0; i < arrA.Length; i++)
            {
                if (arrA[i] != arrB[i])
                {
                    areEqual = false;
                    result = (arrA[i] < arrB[i]) ? "<" : ">";
                    break;
                }
            }
        }

        Console.WriteLine(areEqual ? "=" : result);
    }
}
//Reshenie na Dushka(Purviq programist na zemqta)

  //  using System;
  //
  // namespace CompareCharArrays
  //  {
  //  class Program
  //  {
  //      static void Main()
  //      {
  //          string input = Console.ReadLine();
  //          string input1 = Console.ReadLine();
  //          input = input.ToLower();
  //          input1 = input1.ToLower();
  //          char[] Arr = input.ToCharArray();
  //          char[] Arr1 = input1.ToCharArray();
  //          int sum1 = 0;
  //          int sum2 = 0;
  //          if (Arr.Length > Arr1.Length)
  //          {
  //              Console.WriteLine('>');
  //          }
  //          else if (Arr.Length < Arr1.Length)
  //          {
  //              Console.WriteLine('<');
  //          }
  //          else
  //          {
  //              for (int i = 0; i < Arr.Length; i++)
  //              {
  //                  sum1 += Arr[i];
  //                  sum2 += Arr1[i];
  //              }
  //              if (sum1 < sum2)
  //              {
  //                  Console.WriteLine('<');
  //              }
  //              else if (sum1 > sum2)
  //              {
  //                  Console.WriteLine('>');
  //              }
  //              else
  //              {
  //                  Console.WriteLine('=');
  //              }
  //          }
  //
  //      }
  //  }
 //} 
 //moi izvrashteniq(90/100)