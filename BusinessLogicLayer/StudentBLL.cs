using CommonLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class StudentBLL
    {
        readonly List<StudentEntity> students = new()
        {
            new StudentEntity()
            {
                Id = 1,
                Name = "Name1",
                Email = "name1@gmail.com",
                Age = 20
            },

            new StudentEntity()
            {
                Id = 2,
                Name = "Name2",
                Email = "name2@gmail.com",
                Age = 20
            },

            new StudentEntity()
            {
                Id = 3,
                Name = "Name3",
                Email = "name3@gmail.com",
                Age = 20
            }
        };

        public List<StudentEntity> GetStudentBelow3()
        {
            List<StudentEntity> studentsBelow3 = students.Where(s => s.Id < 3).ToList();
            
            return studentsBelow3;
        }

    }
}