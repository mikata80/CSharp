using System;
class EmployeeData
{
    static void Main()
    {
        string firstname = "Ivan";
        string lastname = "Petrov";
        int age = 34;
        char gender = 'm';
        string pid = "7402147620 ";
        int emplnum = 27565599;
        
        Console.WriteLine("Employee name is {0} {1}, {2} is old, gender \"{3}\" with personal ID number {4} and  unique employee number {5}. ",firstname,lastname,age,gender,pid,emplnum);
        
    }
}
