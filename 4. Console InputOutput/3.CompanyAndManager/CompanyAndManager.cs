using System;
    class CompanyAndManager
    {
        static void Main()
        {
            Console.Write("Name of the company: ");
            string nameCompany = Console.ReadLine();
            Console.Write("Address: ");
            string address = Console.ReadLine();
            Console.Write("Phone number: ");
            string phNumComp = Console.ReadLine();
            Console.Write("Fax number: ");
            long faxNum = long.Parse(Console.ReadLine());
            Console.Write("Web site: ");
            string webSite = Console.ReadLine();
            Console.Write("Manager: ");
            string manager = Console.ReadLine();
            Console.WriteLine("Information about the manager:");
            Console.Write("First name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Phone number: ");
            string phNumMan = Console.ReadLine();
            Console.WriteLine("The company {0} with address {1}, phone number {2}, fax number {3}, web site {4} has a manager - {5}. ", nameCompany, address, phNumComp, faxNum, webSite, manager);
            Console.WriteLine("Its manager {0} {1} is {2} years old and his phone number is {3}.", firstName, lastName, age, phNumMan);
        }
    }
