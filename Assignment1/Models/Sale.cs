using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTimeOffset Date { set; get; }
        public Customer Customer { get; set; }
        public StoreLocation StoreLocation { get; set; }
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public string EmloyeeToApproveId { get; set; }
        public Employee EmployeeToApprove { get; set; }
        public ICollection<Product> Products { get; set; }

        public Sale()
        {
            Products = new List<Product>();
        }
    }
}