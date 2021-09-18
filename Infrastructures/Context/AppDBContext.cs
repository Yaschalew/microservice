using Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructures.Context
{
   public class AppDBContext:DbContext
    {

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
              
        }
        public DbSet<Student> students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

    }
}
