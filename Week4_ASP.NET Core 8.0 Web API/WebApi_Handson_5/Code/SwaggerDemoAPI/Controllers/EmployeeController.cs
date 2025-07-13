using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SwaggerDemoAPI.Models;

namespace SwaggerDemoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin,POC")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> _employees = new();

        public EmployeeController()
        {
            if (_employees.Count == 0)
                _employees = GetStandardEmployeeList();
        }

        [HttpGet]
        public ActionResult<List<Employee>> GetStandard()
        {
            return Ok(_employees);
        }

        [HttpPost]
        public ActionResult<Employee> Post([FromBody] Employee emp)
        {
            _employees.Add(emp);
            return CreatedAtAction(nameof(GetStandard), emp);
        }

        [HttpPut("{id}")]
        public ActionResult<Employee> Put(int id, [FromBody] Employee updated)
        {
            if (id <= 0) return BadRequest("Invalid employee id");

            var existingEmp = _employees.FirstOrDefault(e => e.Id == id);
            if (existingEmp == null) return BadRequest("Invalid employee id");

            existingEmp.Name = updated.Name;
            existingEmp.Salary = updated.Salary;
            existingEmp.Permanent = updated.Permanent;
            existingEmp.Department = updated.Department;
            existingEmp.Skills = updated.Skills;
            existingEmp.DateOfBirth = updated.DateOfBirth;

            return Ok(existingEmp);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var emp = _employees.FirstOrDefault(e => e.Id == id);
            if (emp == null) return BadRequest("Invalid employee id");

            _employees.Remove(emp);
            return NoContent();
        }

        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Uttaran Sarkar",
                    Salary = 50000,
                    Permanent = true,
                    Department = new Department { Id = 1, Name = "HR" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 1, Name = "C#" },
                        new Skill { Id = 2, Name = "SQL" }
                    },
                    DateOfBirth = new DateTime(2004, 3, 29)
                },
                new Employee
                {
                    Id = 2,
                    Name = "Himmat Singh",
                    Salary = 55000,
                    Permanent = true,
                    Department = new Department { Id = 1, Name = "HR" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 1, Name = "C#" },
                        new Skill { Id = 2, Name = "SQL" }
                    },
                    DateOfBirth = new DateTime(2000, 4, 23)
                }
            };
        }
    }
}
