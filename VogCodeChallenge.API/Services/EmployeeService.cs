using System;
using System.Collections.Generic;
using VogCodeChallenge.API.Modals;
using VogCodeChallenge.API.Repositories;

namespace VogCodeChallenge.API.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employeeRepository.FindAll();
        }

        public IList<Employee> ListAll()
        {
            return (IList<Employee>)_employeeRepository.FindAll();
        }

        public IEnumerable<Employee> GetEmployeesByDepartmentId(int departmentId)
        {
            return _employeeRepository.FindByDepartmentId(departmentId);
        }
    }
}
