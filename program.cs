// See https://aka.ms/new-console-template for more information
Console.WriteLine("Monthly Salary");
var salary = Console.ReadLine();
Console.WriteLine("Rent?");
var rent = Console.ReadLine();
Console.WriteLine("Uitlites");
var util = Console.ReadLine();
Console.WriteLine("Groocies");
var groc = Console.ReadLine();
var salaryp = int.Parse(salary);
var rentp = int.Parse(rent);
var utilp = int.Parse(util);
var grocp = int.Parse(groc);
int sum = salaryp - (rentp + utilp + grocp);
Console.WriteLine(sum);
