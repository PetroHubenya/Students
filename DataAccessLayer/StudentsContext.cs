using CommonLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class StudentsContext : DbContext
    {
        public StudentsContext(DbContextOptions<StudentsContext>option) : base(option)
        {
            
        }

        public DbSet<StudentEntity>Students { get; set; }
    }
}
