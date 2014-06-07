using System;

class BankAccountData
{
    static void Main()
    {
        string firstname = "Ivan";
        string middlename = "Iliev";
        string lastname = "Petrov";
        string bankname = "MPBannk";
        string IBAN = "MPB121212U121235";
        string creditcard1 = "121-123-1235";
        string creditcard2 = "121-112-1233";
        string creditcard3 = "121-112-1998";
        decimal balance = 1550.15m;


        Console.WriteLine("{0} {1} {2}, BANK NAME: {3} , IBAN = {4}-> Credit Card Number 1 {5};Credit Card Number 2 {6}, Credit Card Number 3 {7} , Blance: {8}", firstname, middlename, lastname, bankname, IBAN, creditcard1, creditcard2, creditcard3, bankname);
    }
}
