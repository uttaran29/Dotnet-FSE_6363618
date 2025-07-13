using Microsoft.AspNetCore.Mvc;
using SwaggerDemoAPI.Filters;
using SwaggerDemoAPI.Models;

namespace SwaggerDemoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ServiceFilter(typeof(CustomAuthFilter))]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> _employees = new();

        public EmployeeController()
        {
            if (_employees.Count == 0)
                _employees = GetStandardEmployeeList();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<Employee>> GetStandard()
        {
            return Ok(_employees);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<Employee> Post([FromBody] Employee emp)
        {
            _employees.Add(emp);
            return CreatedAtAction(nameof(GetStandard), emp);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Employee> Put(int id, [FromBody] Employee updated)
        {
            if (id <= 0)
                return BadRequest("Invalid employee id");

            var existingEmp = _employees.FirstOrDefault(e => e.Id == id);
            if (existingEmp == null)
                return BadRequest("Invalid employee id");

            existingEmp.Name = updated.Name;
            existingEmp.Salary = updated.Salary;
            existingEmp.Permanent = updated.Permanent;
            existingEmp.Department = updated.Department;
            existingEmp.Skills = updated.Skills;
            existingEmp.DateOfBirth = updated.DateOfBirth;

            return Ok(existingEmp);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Delete(int id)
        {
            var emp = _employees.FirstOrDefault(e => e.Id == id);
            if (emp == null)
                return BadRequest("Invalid employee id");

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
                    DateOfBirth = new DateTime(1990, 1, 1)
                },
                new Employee
                {
                    Id = 2,
                    Name = "Aahan Sharma",
                    Salary = 60000,
                    Permanent = false,
                    Department = new Department { Id = 2, Name = "Finance" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 3, Name = "Excel" }
                    },
                    DateOfBirth = new DateTime(1995, 5, 20)
                }
            };
        }
    }
}
