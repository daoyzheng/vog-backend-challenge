using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VogCodeChallenge.API.Modals;
using VogCodeChallenge.API.Services;

namespace VogCodeChallenge.API.Controllers
{
    [ApiController]
    [Route("api/employees")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetAll()
        {
            return Ok(_employeeService.GetAll());
        }

        [HttpGet("department/{departmentId}")]
        public ActionResult<IEnumerable<Employee>> GetEmployeeByDepartmentId(int departmentId)
        {
            return Ok(_employeeService.GetEmployeesByDepartmentId(departmentId));
        }
    }
}
