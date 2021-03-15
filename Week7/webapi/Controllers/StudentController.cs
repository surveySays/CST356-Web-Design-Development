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
        private readonly SchoolContext _dbContext;

        // private readonly ILogger<StudentController> _logger;

        public StudentController(SchoolContext dbContext)
        {
            _dbContext = dbContext;
            // _logger = logger;
        }

        [HttpGet]
        public ActionResult<List<Student>> GetAllProducts()
        {
            var result = _dbContext.Student.ToList();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public ActionResult<Student> GetProduct(int id)
        {
             var student = _dbContext.Student
                .SingleOrDefault(p => p.StudentId == id);

            if (student != null) {
                return student;
            } else {
                return NotFound();
            }
        }

        // [HttpGet]
        // public IActionResult Get()
        // {
        //     var result = _dbContext.Student.ToList();
        //     return Ok(result);
        // }

        // [HttpGet("{id}")]
        // public IActionResult GetById(int id)
        // {
        //     if (id == 0)
        //     {
        //         return BadRequest();
        //     }

        //     // var student = InMemory.Students.FirstOrDefault(s => s.Id == id);
        //     var student = _dbContext.Student
        //         .SingleOrDefault(p => p.StudentId == id);

        //     if (student == null)
        //     {
        //         return NotFound();
        //     }

        //     return Ok(student);
        // }

        // private List<Student> getStudents()
        // {
        //     return InMemory.Students;
        // }

        // private int getNextId()
        // {
        //     return InMemory.Students.Max(p => p.Id) + 1;
        // }
    }
}