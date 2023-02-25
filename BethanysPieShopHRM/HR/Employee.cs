using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BethanysPieShopHRM.HR
{
    internal class Employee
    {
        private string firstName;
        private string lastName;
        private string email;

        private int numberOfHoursWorked;
        private double wage;
        private double hourlyRate;
      
        private DateTime birthDate;
        private const int minumalHoursWorkedUnit = 1;
        //private EmployeeType employeeType;

        private Address address;

        public static double taxRate = 0.15;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName= value;
            }
        }  
        
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            {
                birthDate = value;
            }
        }

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        public int NumberOfHoursWorked
        {
            get
            {
                return numberOfHoursWorked;
            }
            protected set
            {
                numberOfHoursWorked = value;
            }
        } 
        
        public double Wage
        {
            get
            {
                return wage;
            }
            private set
            {
                wage = value;
            }
        }  
        public double HourlyRate
        {
            get
            {
                return hourlyRate;
            }
            set
            {
                if (hourlyRate < 0)
                {
                    hourlyRate = 0;
                }
                else
                {
                    hourlyRate = value;
                }
               
            }
        } 
     /*   public EmployeeType EmployeeType
        {
            get
            {
                return employeeType;
            }
            set
            {
                employeeType = value;
            }
        }*/


       //public Employee(string firstName, string lastName, string email, DateTime birthDate) : this(firstName, lastName, email, birthDate, 0, EmployeeType.StoreManager)
       public Employee(string firstName, string lastName, string email, DateTime birthDate) : this(firstName, lastName, email, birthDate, 0)
        {
        }


        //public Employee(string firstName, string lastName, string email, DateTime birthDate, double hourlyRate, EmployeeType employeeType)
        public Employee(string firstName, string lastName, string email, DateTime birthDate, double hourlyRate)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDate = birthDate;
            HourlyRate = hourlyRate;
            //EmployeeType = employeeType;
        }

        public Employee(string firstName, string lastName, string email, DateTime birthDate, double hourlyRate, string street, string houseNumber, string zip, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDate = birthDate;
            HourlyRate = hourlyRate;
            //EmployeeType = employeeType;

            Address = new Address(street, houseNumber, zip, city);
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
            NumberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{FirstName} {LastName} has worked for {numberOfHours} hour(s).");
        }

        public double ReceiveWage(bool resetHours = true)
        {

            double wageBeforeTax = 0.0;

            /*   if (EmployeeType == EmployeeType.Manager)
               {

                   double extra_coef = 1.25;
                   wageBeforeTax = NumberOfHoursWorked * HourlyRate * extra_coef;

                   Console.WriteLine($"An extra was added to the wage(coefficient: {extra_coef}) since {FirstName} {LastName} is a manager.");
               }
               else
               {
                   wageBeforeTax = NumberOfHoursWorked * HourlyRate;
               }

               double taxAmount = wageBeforeTax * taxRate;

               Wage = wageBeforeTax - taxAmount;
            */
            double taxAmount = wageBeforeTax * taxRate;
            wageBeforeTax = NumberOfHoursWorked * HourlyRate;
            Wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"{FirstName} {LastName} has received a wage of {Wage} before taxes for {NumberOfHoursWorked} hour(s) of work.");

            if (resetHours)
                NumberOfHoursWorked = 0;
            return Wage;

     
        }

        public virtual void GiveBonus()
        {
            Console.WriteLine($"{FirstName} {LastName} received a generic bonus of 100!");
        }

    }
}


