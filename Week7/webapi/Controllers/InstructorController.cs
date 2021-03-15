// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Logging;
// using Database;

// namespace webapi.Controllers
// {
//     [ApiController]
//     [Route("api/[controller]")]
//     public class InstructorController : ControllerBase
//     {
//         private readonly ILogger<InstructorController> _logger;

//         public InstructorController(ILogger<InstructorController> logger)
//         {
//             _logger = logger;
//         }

//         [HttpGet]
//         public IActionResult Get()
//         {
//             return Ok(getInstructors());
//         }

// private List<Instructor> getInstructors()
// {
//     return InMemory.Instructors;
// }

//     }
// }