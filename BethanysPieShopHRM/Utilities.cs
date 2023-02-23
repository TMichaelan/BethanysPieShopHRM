using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM
{
    internal class Utilities
    {
        public static void UsingSimpleStrings()
        {
            string firstName = "Bethany", lastname = "Smith";
            string s;
            s = firstName;
            var userName = "BethanyS";
            userName = userName.ToLower();
            userName = ""; //identical to string.Empty

        } 
        public static int  CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        {
            return monthlyWage * numberOfMonthsWorked;

        } 
        public static int CalculateYearlyWageExpressionBodied(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {
            return monthlyWage * numberOfMonthsWorked + bonus;
        }
        
        public static void UsingExpressionBodiedSyntax()
        {
            int amount = 1234;
            int month = 12;
            int bonus = 500;

            int yearlyWageForEmploee1 = CalculateYearlyWageExpressionBodied(amount,month,bonus);

            Console.WriteLine($"Yearly wage for emploee 1 (Bethany) : {yearlyWageForEmploee1}");
        }

        public static int CalculateYearlyWageExpressionBodiedSyntax(int monthlyWage, int numberOfMonthsWorked, int bonus) => monthlyWage * numberOfMonthsWorked + bonus;



    }
}
