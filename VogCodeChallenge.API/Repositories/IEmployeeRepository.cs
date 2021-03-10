using System;
using System.Collections.Generic;
using VogCodeChallenge.API.Modals;

namespace VogCodeChallenge.API.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> FindAll();

        IEnumerable<Employee> FindByDepartmentId(int departmentId);
    }
   
}
