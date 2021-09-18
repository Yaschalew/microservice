using Domains;
using Domains.Interfaces;
using Infrastructures.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructures.Repo
{
    public class StudentRepo : IStudent
    {
        private readonly AppDBContext _context;
        public StudentRepo(AppDBContext context)
        {
            _context = context;
        }
        public bool addStudent(Student student)
        {
            _context.students.Add(student);
            _context.SaveChanges();
            return true;
        }
        public IEnumerable<Student> getStudent()
        {
          return  _context.students;
        }
    }
}
