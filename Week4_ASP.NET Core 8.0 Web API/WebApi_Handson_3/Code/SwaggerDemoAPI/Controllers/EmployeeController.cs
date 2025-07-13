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
        public ActionResult<Employee> Post([FromBody] Employee emp)
        {
            _employees.Add(emp);
            return CreatedAtAction(nameof(GetStandard), emp);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Employee updated)
        {
            var emp = _employees.FirstOrDefault(e => e.Id == id);
            if (emp == null) return NotFound();

            emp.Name = updated.Name;
            emp.Salary = updated.Salary;
            emp.Permanent = updated.Permanent;
            emp.Department = updated.Department;
            emp.Skills = updated.Skills;
            emp.DateOfBirth = updated.DateOfBirth;

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
                    Skills = new List<Skill> { new Skill { Id = 1, Name = "C#" }, new Skill { Id = 2, Name = "SQL" } },
                    DateOfBirth = new DateTime(1990, 1, 1)
                }
            };
        }
    }
}
