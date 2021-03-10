using System;
using System.Collections.Generic;
using VogCodeChallenge.API.Modals;

namespace VogCodeChallenge.API.Repositories
{
    public class MockEmployeeRepository : IEmployeeRepository
    {

        public IEnumerable<Employee> FindAll()
        {
            return Employees;
        }

        public IEnumerable<Employee> FindByDepartmentId(int departmentId)
        {
            return Employees.FindAll(employee => employee.DepartmentId == departmentId);
        }

        private readonly List<Employee> Employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,

                FirstName = "Jon",

                LastName = "Dummy1",

                JobTitle = "Developer",

                MailingAddress = "123 street, A1A 1A1",

                DepartmentId = 1
            },
            new Employee
            {
                Id = 2,

                FirstName = "Bob",

                LastName = "Dummy2",

                JobTitle = "BackEnd Developer",

                MailingAddress = "321 street, A2A 2A2",

                DepartmentId = 1
            },
            new Employee
            {
                Id = 3,

                FirstName = "Will",

                LastName = "Dummy3",

                JobTitle = "FrontEnd Developer",

                MailingAddress = "321 ave, A3A 3A3",

                DepartmentId = 1
            },
            new Employee
            {
                Id = 4,

                FirstName = "Jane",

                LastName = "Dummy4",

                JobTitle = "UI Designer",

                MailingAddress = "123 ave, A4A 4A4",

                DepartmentId = 2
            },
        };
    }
}
