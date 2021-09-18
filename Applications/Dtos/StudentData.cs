using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Dtos
{
   public class StudentData
    {
        public IEnumerable<Student> students { get; set; }
    }
}
