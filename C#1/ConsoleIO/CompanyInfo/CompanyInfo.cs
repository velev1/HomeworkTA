﻿using System;

class CompanyInfo
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAdress = Console.ReadLine();
        string phoneNumber = Console.ReadLine();
        string faxNumber = Console.ReadLine();
        string webSite = Console.ReadLine();
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        string managerAge = Console.ReadLine();
        string managerPhone = Console.ReadLine();

        if (faxNumber == string.Empty)
        {
            faxNumber = "(no fax)";
        }
        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}",companyAdress);
        Console.WriteLine("Tel. {0}",phoneNumber);
        Console.WriteLine("Fax: {0}",faxNumber);
        Console.WriteLine("Web site: {0}",webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName,managerLastName,managerAge, managerPhone);
    }
}

