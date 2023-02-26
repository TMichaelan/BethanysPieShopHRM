using BethanysPieShopHRM;
using BethanysPieShopHRM.HR;
using System.Collections.Immutable;
using System.Text;

/*
int yearlyWage = Utilities.CalculateYearlyWage(12, 12);
int yearlyWage2 = Utilities.CalculateYearlyWageExpressionBodiedSyntax(12, 12, 12);

Console.WriteLine($"Yearly wage: {yearlyWage} and {yearlyWage2}");
*/

/*
Console.WriteLine("Creating an employee");
Console.WriteLine("---------------------\n");

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime (1979,1,16), 25);

bethany.DisplayEmploeeDetails();



Employee test_emp = new("TestName", "TestSurname", "test@mail.com", new DateTime(2001, 08, 28), 10);

test_emp.DisplayEmploeeDetails();

Employee george = new("George", "Jones", "gjones@mail.com", new DateTime(1987, 05, 14), 20);

george.DisplayEmploeeDetails();


bethany.PerformWork(8);
bethany.ReceiveWage();
*/


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

/*
WorkTask task;

task.description = "Bake delicious pies";
task.hours = 3;
task.PerformWorkTask();
*/

// BethanysPieShopHRM.Accounting.Customer customer = new BethanysPieShopHRM.Accounting.Customer();
/*

#region First run Bethany

bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork();
bethany.PerformWork();
bethany.DisplayEmploeeDetails();
bethany.ReceiveWage();

#endregion

#region First run George

george.PerformWork(10);
george.PerformWork();
george.PerformWork();
george.PerformWork();
george.DisplayEmploeeDetails();
george.ReceiveWage();

#endregion

Employee.taxRate = 0.02;

#region First run Bethany

bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork();
bethany.PerformWork();
bethany.DisplayEmploeeDetails();
bethany.ReceiveWage();

#endregion

#region First run George

george.PerformWork(10);
george.PerformWork();
george.PerformWork();
george.PerformWork();
george.DisplayEmploeeDetails();
george.ReceiveWage();

#endregion
*/
//Lists
/*
int[] sampleArray1 = new int[5];
int[] sampleArray2 = new int[] {1,2,3,4,5};

Console.WriteLine("How many employees IDs do you want to register?");
int length = int.Parse(Console.ReadLine());

int[] employeeIds = new int[length];

var testId = employeeIds[0];

for (int i = 0;i < length; i++)
{
    Console.WriteLine("Enter Employee ID: ");
    int id = int.Parse(Console.ReadLine());
    employeeIds[i] = id;
}

for (int i = 0;i < employeeIds.Length; i++)
{
    Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]} ");
}


int[] employeeIdsCopy = new int[length];

employeeIds.CopyTo(employeeIdsCopy, 0);

Array.Sort(employeeIds);

Console.WriteLine($"IDs after sort");
for (int i = 0; i < employeeIds.Length; i++)
{
    Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]} ");
}

Array.Reverse(employeeIds);

Console.WriteLine($"IDs after reverse");
for (int i = 0; i < employeeIds.Length; i++)
{
    Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]} ");
}
*/
//Collections

/*
List<int> employeeIdss = new List<int>();

employeeIdss.Add(55);
employeeIdss.Add(1);
employeeIdss.Add(943);
employeeIdss.Add(78);
employeeIdss.Add(79);


if (employeeIdss.Contains(55))
{
    Console.WriteLine("55 is found!");
}

int currentAmountOfEmployees = employeeIdss.Count;

var employeeIdsArray = employeeIdss.ToArray();

employeeIdss.Clear();


Console.WriteLine("How many employees IDs do you want to register?");


int length2 = int.Parse(Console.ReadLine());


for (int i = 0; i < length2; i++)
{
    Console.WriteLine("Enter Employee ID: ");
    int id = int.Parse(Console.ReadLine());
    employeeIdss.Add(id);
}

for (int i = 0; i < employeeIdss.Count; i++)
{
    Console.WriteLine($"ID {i + 1}: \t{employeeIdss[i]} ");
}

*/

/*

Employee mary = new("Mary", "Jones", "mary@mail.com", new DateTime(1987, 01, 15), 30);
//Employee bobJunior = new("Bob", "Spancer", "bobcancer@mail.com", new DateTime(1993, 08, 1), 20);
Employee kevin = new("Kevin", "Marks", "kevin@mail.com", new DateTime(1965, 02, 13), 15);
Employee kate = new("Kate", "Greggs", "kate@mail.com", new DateTime(1999, 03, 15), 15);
Employee kim = new("Kim", "Jacobs", "kim@mail.com", new DateTime(2000, 06, 8), 15);

List<Employee> employees = new List<Employee>();

employees.Add(george);
employees.Insert(0, bethany);
employees.Add(mary);
//employees.Add(bobJunior);
employees.Add(kevin);
employees.Add(kate);
employees.Add(kim);

foreach(Employee employee in employees)
{
    employee.DisplayEmploeeDetails();
}

//Derived Class

Employee loh = new Manager("Kim", "Jacobs", "kim@mail.com", new DateTime(2000, 06, 8), 15);

loh.PerformWork(20);
loh.ReceiveWage();
loh.DisplayEmploeeDetails();

//loh.AttendManagementMeeting();

Researcher bobJunior = new JuniorResearcher("Bob", "Spancer", "bobcancer@mail.com", new DateTime(1993, 08, 1), 20);

bobJunior.ResearchNewPieTastes(5);
bobJunior.ResearchNewPieTastes(5);

Employee jake = new Employee("Jake", "Nicols", "jake@mail.com", new DateTime(1995, 02, 6), 16,"New street","123","123456","Pie Ville");

string streetName = jake.Address.ToString();


mary.GiveBonus();

//IEmployee newJake = new Employee("Jake", "Nicols", "jake@mail.com", new DateTime(1995, 02, 6), 16, "New street", "123", "123456", "Pie Ville");

IEmployee bobJunior1 = new JuniorResearcher("Bob", "Spancer", "bobcancer@mail.com", new DateTime(1993, 08, 1), 20);
IEmployee kevin2 = new Researcher("Kevin", "Marks", "kevin@mail.com", new DateTime(1965, 02, 13), 15);
IEmployee kate2 = new Manager("Kate", "Greggs", "kate@mail.com", new DateTime(1999, 03, 15), 15);
IEmployee kim2 = new Researcher("Kim", "Jacobs", "kim@mail.com", new DateTime(2000, 06, 8), 15);
*/



List<Employee> employees = new List<Employee>();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("***********************************");
Console.WriteLine("* Bethany's Pie Shop Employee App *");
Console.WriteLine("***********************************");
Console.ForegroundColor = ConsoleColor.White;

string userSelection;
Console.ForegroundColor = ConsoleColor.Blue;

Utilities.CheckForExistingEmployeeFile();

do
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"Loaded {employees.Count} employee(s)\n\n");

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("********************");
    Console.WriteLine("* Select an action *");
    Console.WriteLine("********************");

    Console.WriteLine("1: Register employee");
    Console.WriteLine("2: View all employees");
    Console.WriteLine("3: Save data");
    Console.WriteLine("4: Load data");
    Console.WriteLine("9: Quit application");
    Console.Write("Your selection: ");

    userSelection = Console.ReadLine();

    switch (userSelection)
    {
        case "1":
            Utilities.RegisterEmployee(employees);
            break;
        case "2":
            Utilities.ViewAllEmployees(employees);
            break;
        case "3":
            Utilities.SaveEmployees(employees);
            break;
        case "4":
            Utilities.LoadEmployees(employees);
            break;
        case "9": break;
        default:
            Console.WriteLine("Invalid selection. Please try again.");
            break;
    }
}
while (userSelection != "9");

Console.WriteLine("Thanks for using the application");