using System;
class CompanyInformation
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyname = Console.ReadLine();
        Console.Write("Company address: ");

        string companyaddress = Console.ReadLine();

        Console.Write("Phone number: ");
        string companyphone = Console.ReadLine();

        Console.Write("Fax number: ");
        string conpanyfax = Console.ReadLine();

        Console.Write("Web site: ");
        string companyweb = Console.ReadLine();

        Console.Write("Manager first name:");
        string manfirstname = Console.ReadLine();

        Console.Write("Manager last name:");
        string manlastname = Console.ReadLine();

        Console.Write("Manager age:");
        int manage = int.Parse(Console.ReadLine());

        Console.Write("Manager phone number:");
        string manphone = Console.ReadLine();
        
        Console.WriteLine(companyname);
        Console.WriteLine("Address: {0}", companyaddress != "" ? companyaddress : "(no Address)");
        Console.WriteLine("Tel. {0},", companyphone != "" ? companyphone : "(no Tel.)");
        Console.WriteLine("Fax: {0}",conpanyfax !=""? conpanyfax : "(no fax)" );
        Console.WriteLine("Web site: {0}", companyweb != "" ? companyweb : "(Web site)");
        Console.WriteLine("Manager: {0} (age: {1}, tel. {2}) ", (manfirstname != "" && manlastname != "") ? manfirstname + " " + manlastname : "(no manager)", (manage != 0) ? Convert.ToString(manage) : "(no age)", manphone != "" ? manphone : "(no tel.)");

    }
}
