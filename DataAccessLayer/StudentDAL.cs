using CommonLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace DataAccessLayer
{
    public class StudentDAL
    {
        private readonly StudentsContext context;
		public StudentDAL(StudentsContext context)
		{
			this.context = context;
		}
		public List<StudentEntity> GetStudents()
		{
			List<StudentEntity> students = context.Students.ToList();
            return students;
		}
	}
}
