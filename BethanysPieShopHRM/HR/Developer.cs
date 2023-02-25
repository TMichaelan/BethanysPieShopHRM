using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.HR
{
    internal class Developer : Employee
    {
        private string currentProject;

        public Developer(string firstName, string lastName, string email, DateTime birthDate) : base(firstName, lastName, email, birthDate)
        {
        }

        public string CurrentProject
        { get { return currentProject; } set { currentProject = value; } }
    
    }
}
