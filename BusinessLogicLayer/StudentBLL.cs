using CommonLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class StudentBLL
    {
        private readonly StudentDAL _studentDAL;

        public StudentBLL()
        {
            _studentDAL = new StudentDAL();
        }

        public List<StudentEntity> GetStudentBelow3()
        {
            List<StudentEntity> studentsBelow3 = _studentDAL.FetchStudents().Where(s => s.Id < 3).ToList();
            
            return studentsBelow3;
        }
    }
}