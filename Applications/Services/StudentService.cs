using Applications.Dtos;
using Applications.Interfaces;
using Domains;
using Domains.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudent _student;

        public StudentService(IStudent student)
        {
            _student = student;
        }
        public bool addStudent(StudentItem studentItem)
        {
            Student student = new Student();
            student.Name = studentItem.Name;
            return _student.addStudent(student);
        }

        public StudentData getStudent()
        {
            StudentData studentData = new StudentData()
            {
                students = _student.getStudent()
            };
            return studentData;
        }
    }
}
