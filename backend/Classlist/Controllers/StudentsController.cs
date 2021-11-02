using Classlist.Services;
using Microsoft.AspNetCore.Mvc;

namespace Classlist.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly StudentsService studentsService;

        public StudentsController(StudentsService studentsService)
        {
            this.studentsService = studentsService;
        }

        [HttpGet]
        [Route("{clazzId}")]
        public IActionResult GetStudensForClazz(int clazzId)
        {
            if (clazzId < 0) return BadRequest("Invalid id!");
            return Ok(studentsService.GetStudentsForClazz(clazzId));
        }

        [HttpPut]
        [Route("setAge")]
        public IActionResult SetAge(int studentId, int age)
        {
            if (studentId < 0 || age < 0) return BadRequest("Invalid query parameters");
            var student = studentsService.SetAge(studentId, age);

            if (student == null) return BadRequest("Student not found!");
            return Ok(student);
        }

        [HttpPut]
        [Route("setClazz")]
        public IActionResult SetClazz(int studentId, int clazzId)
        {
            if (studentId < 0 || clazzId < 0) return BadRequest("Invalid id!");
            var student = studentsService.SetClazz(studentId, clazzId);

            if (student == null) return BadRequest("Student not found!");
            return Ok(student);
        }

        [HttpPut]
        [Route("setRegistered")]
        public IActionResult SetRegistered(int studentId, bool registered)
        {
            if (studentId < 0) return BadRequest("Invalid id!");
            var student = studentsService.SetRegistered(studentId, registered);

            if (student == null) return BadRequest("Student not found!");
            return Ok(student);
        }
    }
}
