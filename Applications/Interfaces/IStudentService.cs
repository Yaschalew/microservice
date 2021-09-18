using Applications.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Interfaces
{
   public interface IStudentService
    {
        public StudentData getStudent();
        public Boolean addStudent(StudentItem studentItem);
    }
}
