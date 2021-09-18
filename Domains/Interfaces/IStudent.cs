using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Interfaces
{
   public interface IStudent
    {
        public IEnumerable<Student> getStudent();
        public Boolean addStudent(Student student);
    }
}
