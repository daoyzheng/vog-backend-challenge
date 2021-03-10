using System;
using System.Collections.Generic;

namespace VogCodeChallenge.API.Modals
{
    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
