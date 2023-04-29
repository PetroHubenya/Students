using CommonLayer;
using DataAccessLayer;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogicLayer
{
    public class StudentBLL
    {
        private readonly StudentDAL _studentDAL;

        public StudentBLL()
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            _studentDAL = new StudentDAL(configuration);
        }

        public List<StudentEntity> GetStudentBelow3()
        {
            List<StudentEntity> studentsBelow3 = _studentDAL.FetchStudents().Where(s => s.Id < 3).ToList();
            
            return studentsBelow3;
        }
    }
}