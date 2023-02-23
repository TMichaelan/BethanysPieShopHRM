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

            if (employeeType == EmployeeType.Manager)
            {

                double extra_coef = 1.25;
                wage = numberOfHoursWorked * hourlyRate * extra_coef;

                Console.WriteLine($"An extra was added to the wage(coefficient: {extra_coef}) since {firstName} {lastName} is a manager.");
            }
            else
            {
                wage = numberOfHoursWorked * hourlyRate;
            }


            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hour(s) of work.");

            if (resetHours)
                numberOfHoursWorked = 0;
            return wage;
        }

        public double taxToPay()
        {
            double tax = 0;

            if (wage > 300)
                tax = wage * 0.23;

            Console.WriteLine($"{firstName} {lastName} has to pay tax a wage of {tax} for {wage}$.");

            return tax;
        }



    }
}


