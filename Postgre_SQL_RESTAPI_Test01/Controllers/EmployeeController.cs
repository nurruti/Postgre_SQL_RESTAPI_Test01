using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Postgre_SQL_RESTAPI_Test01.Models;

namespace Postgre_SQL_RESTAPI_Test01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //Generate this from scaffolding
        //PostgreContext dbPG = new PostgreContext();

        #region Get Employees
        [HttpGet]
        [Route ("GetEmployees")]
        public IActionResult GetEmployees()
        {
            var empList = from e in [dbo].[Employees]
                          select e;

            return Ok(empList);
        }
        #endregion
        /*
        #region Search Employees
        [HttpGet]
        [Route("SearchEmployees/{empID}")]
        public IActionResult SearchEmployee(int id)
        {
            var searchResult = from e in [dbo].[Employees]
                               where e.e.Contains(id)
                               select e;
            return Ok(searchResult);
        }
        #endregion

        #region Add Employee
        [HttpPost]
        [Route("AddEmployee")]
        public IActionResult AddEmployee(Employee employee)
        {


            return Ok(employee);
        }
        #endregion

        #region Update Employee
        [HttpPut]
        [Route("UpdateEmployee/{empID}")]
        public IActionResult UpdateEmployee(Employee employee)
        {


            return Ok();
        }
        #endregion

        #region Delete Employee

        #endregion
        */
    }
}
