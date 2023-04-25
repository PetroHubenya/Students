using CommonLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class StudentDAL
    {
        
        public List<StudentEntity> studentsListDAL = new();
        public List<StudentEntity> FetchStudents()
        {   
            // Create connection string.
            string connectionString = "Data Source=DESKTOP-I1QO562;Initial Catalog=Students;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
                
            // Create connection to the SQL database.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create SQL query.
                string sqlQuery = "SELECT * FROM Student;";

                // Create SQL command.
                using (SqlCommand command = new SqlCommand(sqlQuery, connection)) 
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            StudentEntity student = new StudentEntity();
                            student.Id = reader.GetInt32(0);
                            student.Name = reader.GetString(1);
                            student.Email = reader.GetString(2);
                            student.Age = reader.GetInt32(3);

                            studentsListDAL.Add(student);
                        }
                    }
                }
            }
            
            return studentsListDAL;
        }
    }
}
