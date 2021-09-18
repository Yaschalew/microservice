using Applications.Dtos;
using Applications.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [HttpPost]
        public Boolean addStudent(StudentItem studentItem)
        {
            return _studentService.addStudent(studentItem);
        }

        [HttpGet]

        public StudentData getStudent()
        {
            return _studentService.getStudent();
        }



    }
}
