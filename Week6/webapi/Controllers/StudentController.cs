using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Database;

namespace webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(getStudents());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var student = InMemory.Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        private List<Student> getStudents()
        {
            return InMemory.Students;
        }

        private int getNextId()
        {
            return InMemory.Students.Max(p => p.Id) + 1;
        }
    }
}