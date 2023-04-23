using CommonLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    internal class StudentContext : DbContext
    {
        public DbSet<StudentEntity> Students { get; set; }
    }
}
