using System;

namespace CompanyInfo
{
    class CompanyInfo
    {
        static void Main()
        {
            string CName = Console.ReadLine();
            string Caddress = Console.ReadLine();
            string Phone = Console.ReadLine();
            string Fax = Console.ReadLine();
            string WebSite = Console.ReadLine();
            string ManagerName1 = Console.ReadLine();
            string ManagerName2 = Console.ReadLine();
            string Age = (Console.ReadLine());
            string ManagerPhone = Console.ReadLine();
            Console.WriteLine(CName);
            Console.WriteLine("Address: " + Caddress);
            Console.WriteLine("Tel. " + Phone);
            if (Fax == "")
            {
                Console.WriteLine("Fax: " + "(no fax)");
            }
            else
            {
                Console.WriteLine("Fax: " + Fax);
            }
            Console.WriteLine("Web site: " + WebSite);
            Console.Write("Manager: " + "{0} " + "{1} ", ManagerName1, ManagerName2);
            Console.WriteLine("(age: " + "{0}, " + "tel. " + "{1})", Age, ManagerPhone);

            
        }
    }
}
