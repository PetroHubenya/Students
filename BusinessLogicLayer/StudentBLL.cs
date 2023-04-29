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
        public List<StudentEntity> StudentsListBll { get; set; }

        public List<StudentEntity> StudentsListBelow3Bll { get; set; }

        public StudentEntity StudentBll { get; set; }
        
        
        // private readonly StudentDAL _studentDAL;

        // private readonly StudentsContext _studentsContext;
        
        /*
        public StudentBLL()
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            _studentDAL = new StudentDAL(configuration);
        }
        */

        /*
		public StudentBLL(StudentsContext studentsContext)
		{
			_studentsContext = studentsContext;
		}
        */

		/*
        public List<StudentEntity> GetAllStudents()
        {
            List<StudentEntity> getAllSudents = _studentDAL.FetchStudents();
            return getAllSudents;
        }
        */
        
        /*
        public List<StudentEntity> GetStudentBelow3()
        {
            List<StudentEntity> studentsBelow3 = _studentDAL.FetchStudents().Where(s => s.Id < 3).ToList();
            
            return studentsBelow3;
        }
        */

        // To get list of all students.
		public void GetStudents()
		{
			List<StudentEntity> students = StudentDAL.StudentsList.ToList();
			StudentsListBll = students;
		}

		// To get list of students with Id below 3.
		public void GetStudentsBelow3()
		{
			List<StudentEntity> studentsBelow3 = StudentDAL.StudentsList.Where(s => s.Id < 3).ToList();
			StudentsListBelow3Bll = studentsBelow3;
		}

		// To get single student with needed Id.
		public void GetStudent(int id)
		{
			StudentEntity student = StudentDAL.StudentsList.Find(s => s.Id == id);
            StudentBll = student;
		}
	}
}