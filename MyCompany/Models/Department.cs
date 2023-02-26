using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DepName { get; set; }

        public virtual LinkedList<Employee> Employees { get; set; }
    }
}
