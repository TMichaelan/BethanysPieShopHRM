using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.HR
{
    internal class StoreManager : Employee
    {
        public StoreManager(string firstName, string lastName, string email, DateTime birthDate, double hourlyRate, string street, string houseNumber, string zip, string city) : base(firstName, lastName, email, birthDate, hourlyRate, street, houseNumber, zip, city)
        {
        }
    }
}
