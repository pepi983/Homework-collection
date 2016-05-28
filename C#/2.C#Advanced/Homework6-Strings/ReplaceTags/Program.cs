using System;
using System.Text.RegularExpressions;


namespace ReplaceTags
{
    class Replace
    {
        static void Main()
        {
            string html = Console.ReadLine();

            string markdown = Regex.Replace(html, "(<a href=\")(.*?)(\">)(.*?)(</a>)", "[$4]($2)");

            Console.WriteLine(markdown);
        }
    }
}