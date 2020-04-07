using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using StudentRegistrationDemo3.Models;

namespace StudentRegistrationDemo3.Controllers
{
    [Route("api/[controller]")]
    public class StudentRetrieveController : Controller
    {
        // GET: api/controller
        [HttpGet]
        public List<Student> GetAllStudents()
        {
            return StudentRegistration.GetInstance().GetAllStudents();
        }

        [HttpGet("GetAllStudentRecords")]
        public JsonResult GetAllStudentRecords()
        {
            return Json(GetAllStudents());
        }
    }
}
