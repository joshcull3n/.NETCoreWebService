using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegistrationDemo3.Models
{
    public class StudentRegistration
    {
        List<Student> StudentList;
        static StudentRegistration StdReg = null;

        private StudentRegistration()
        {
            StudentList = new List<Student>();
        }

        public static StudentRegistration GetInstance()
        {
            if (StdReg == null)
            {
                StdReg = new StudentRegistration();
                return StdReg;
            }
            else
            {
                return StdReg;
            }
        }

        public void Add(Student student)
        {
            StudentList.Add(student);
        }

        public List<Student> GetAllStudents()
        {
            return StudentList;
        }

        public string Remove(string RegistrationNumber)
        {
            Student stdn;
            for (int i = 0; i < StudentList.Count; i++)
            {
                if (StudentList[i].RegistrationNumber == RegistrationNumber)
                {
                    stdn = StudentList[i];
                    StudentList.RemoveAt(i);
                    return string.Format("SUCCESS - Student {0} was removed.", stdn.Name);
                }
            }

            return "UNSUCCESSFUL - that registration number was not found";
        }

        public string UpdateStudent(Student inStdn)
        {
            for (int i = 0; i < StudentList.Count; i++)
            {
                Student s = StudentList[i];
                if (s.RegistrationNumber == inStdn.RegistrationNumber)
                {
                    StudentList[i] = inStdn;
                    return string.Format("SUCCESS - Student {0} was updated", inStdn.Name);
                }
            }

            return string.Format("UNSUCCESSFUL - Student {0} was unable to be updated.", inStdn.Name);
        }        
    }
}
