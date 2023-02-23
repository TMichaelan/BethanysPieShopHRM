using BethanysPieShopHRM.HR;
using System.Text;

/*
int yearlyWage = Utilities.CalculateYearlyWage(12, 12);
int yearlyWage2 = Utilities.CalculateYearlyWageExpressionBodiedSyntax(12, 12, 12);

Console.WriteLine($"Yearly wage: {yearlyWage} and {yearlyWage2}");
*/

Console.WriteLine("Creating an employee");
Console.WriteLine("---------------------\n");

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime (1979,1,16), 25, EmployeeType.Manager);

bethany.DisplayEmploeeDetails();



Employee test_emp = new("TestName", "TestSurname", "test@mail.com", new DateTime(2001, 08, 28), 10, EmployeeType.Sales);

test_emp.DisplayEmploeeDetails();

Employee george = new("George", "Jones", "gjones@mail.com", new DateTime(1987, 05, 14), 20, EmployeeType.Research);

george.DisplayEmploeeDetails();


bethany.PerformWork(8);
bethany.ReceiveWage();

/*
bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork(24);
bethany.PerformWork();

bethany.ReceiveWage(false);

bethany.PerformWork();
bethany.PerformWork();
bethany.ReceiveWage();

bethany.taxToPay();
*/

/*
string bethanyAsJson = bethany.ConvertToJson();
Console.WriteLine(bethanyAsJson);
*/

/*StringBuilder builder = new StringBuilder();

string firstName = "Bethany";
string lastName = "Smith";

builder.Append("Last name: ");
builder.AppendLine(lastName);
builder.Append("First name: ");
builder.AppendLine(firstName);
string result = builder.ToString();


StringBuilder builder2 = new StringBuilder();

for (int i = 0; i< 2500; i++)
{
    builder2.Append(i);
    builder2.Append(" ");
}

string list = builder2.ToString();

Console.WriteLine(result);
Console.WriteLine(list);
*/

WorkTask task;

task.description = "Bake delicious pies";
task.hours = 3;
task.PerformWorkTask();