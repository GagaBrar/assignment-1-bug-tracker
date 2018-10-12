using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegistrationNumber { get; set; }
        public ICollection<Sale> Sales { get; set; }
        public Employee()
        {
            Sales = new List<Sale>();
        }
    }
}