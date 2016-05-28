using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseURL
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine("[protocol] = " + input.Substring(0, input.IndexOf(':')));
            Console.WriteLine("[server] = " + input.Substring(input.IndexOf("//") + 2, input.IndexOf("/", input.IndexOf("//") + 2) -input.IndexOf("//") - 2));
            Console.WriteLine("[resource] = " + input.Substring(input.IndexOf("/", input.IndexOf("//") +2)));
            

        }
    }
}

//https://huihui.hui/hui/hui
