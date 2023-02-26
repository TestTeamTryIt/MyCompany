﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Position { get; set; }

        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
