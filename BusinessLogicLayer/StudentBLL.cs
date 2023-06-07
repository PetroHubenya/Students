using CommonLayer;
using DataAccessLayer;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace BusinessLogicLayer
{
    public class StudentBLL
    {
		private readonly StudentDAL studentDAL;		
		public List<StudentEntity> GetAllStudents()
		{
			List<StudentEntity> students = studentDAL.GetStudents();
			return students;
		}
		public List<StudentEntity> GetStudentsBelow3()
		{
			List<StudentEntity> students = studentDAL.GetStudents().Where(s => s.Id < 3).ToList();
			return students;			
		}		
		public StudentEntity GetStudentById(int id)
		{
			List<StudentEntity> students = studentDAL.GetStudents();
			StudentEntity student = students.Find(s => s.Id == id);
            return student;
		}
	}
}