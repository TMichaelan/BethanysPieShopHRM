using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BethanysPieShopHRM.HR
{
    internal class Employee
    {
        public string firstName;
        public string lastName;
        public string email;
        public DateTime birthDate;
        public double wage;


        public int numberOfHoursWorked;
        public double hourlyRate;

        const int minumalHoursWorkedUnit = 1;

        public EmployeeType employeeType;

        public static double taxRate = 0.15;


        public Employee(string fn, string ln, string em, DateTime db) : this(fn, ln, em, db, 0, EmployeeType.StoreManager)
        {
        }


        public Employee(string fn, string ln, string em, DateTime db, double rate, EmployeeType empType)
        {
            firstName = fn;
            lastName = ln;
            email = em;
            birthDate = db;
            hourlyRate = rate;
            employeeType = empType;
        }



        public void DisplayEmploeeDetails()
        {
            Console.WriteLine($"Created employee: \nName:{firstName}\nLast name: {lastName}\nEmail: {email}\nBirth date: {birthDate.ToShortDateString()}\nHourly rate: {hourlyRate}\n");
        }
        
        public static void DisplayTaxRate()
        {
            Console.WriteLine($"The current tax rate is {taxRate}");
        }


        public string ConvertToJson()
        {
            string json = JsonConvert.SerializeObject(this);

            return json;
        }

        public void PerformWork()
        {
            PerformWork(minumalHoursWorkedUnit);
        }

        public void PerformWork(int numberOfHours)
        {
            numberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHours} hour(s).");
        }

        public double ReceiveWage(bool resetHours = true)
        {

            double wageBeforeTax = 0.0;

            if (employeeType == EmployeeType.Manager)
            {

                double extra_coef = 1.25;
                wageBeforeTax = numberOfHoursWorked * hourlyRate * extra_coef;

                Console.WriteLine($"An extra was added to the wage(coefficient: {extra_coef}) since {firstName} {lastName} is a manager.");
            }
            else
            {
                wageBeforeTax = numberOfHoursWorked * hourlyRate;
            }

            double taxAmount = wageBeforeTax * taxRate;

            wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} before taxes (tax amount:{taxAmount}) for {numberOfHoursWorked} hour(s) of work.");

            if (resetHours)
                numberOfHoursWorked = 0;
            return wage;
        }

    }
}


