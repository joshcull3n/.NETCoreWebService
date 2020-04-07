using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using StudentRegistrationDemo3.Models;

namespace StudentRegistrationDemo3.Controllers
{
    [Route("api/[controller]")]
    public class StudentRegistrationController : Controller
    {
        // POST: api/<controller>
        [HttpPost]
        public StudentRegistrationReply RegisterStudent(Student stuReg)
        {
            Console.WriteLine("In RegisterStudent()");
            StudentRegistrationReply StuRegReply = new StudentRegistrationReply();
            StudentRegistration.GetInstance().Add(stuReg);
            StuRegReply.Name = stuReg.Name;
            StuRegReply.Age = stuReg.Age;
            StuRegReply.RegistrationNumber = stuReg.RegistrationNumber;
            StuRegReply.RegistrationStatus = "Successful";

            return StuRegReply;
        }

        [HttpPost("InsertStudent")]
        public IActionResult InsertStudent(Student stuReg)
        {
            return Ok(RegisterStudent(stuReg));
        }

        [Route("student/")]
        [HttpPost("AddStudent")]
        public JsonResult AddStudent(Student stuReg)
        {
            return Json(RegisterStudent(stuReg));
        }

    }
}   
