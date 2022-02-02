using MySql.Data.MySqlClient;
using mysqlwithwebapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mysqlwithwebapp.Services
{
    public class CourseService
    {
        //the server name is similar to what we have given to the container/service name in compose file
        private static string _connection_string = "server=db;user=user;password=Puspraj;database=appdb";
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connection_string);
        }
        public IEnumerable<Course> GetCources()
        {
            List<Course> _lst = new List<Course>();
            string statement = "SELECT * FROM Course";
            MySqlConnection _connection = GetConnection();
            _connection.Open();
            MySqlCommand _command = new MySqlCommand(statement, _connection);
            using (MySqlDataReader _reader = _command.ExecuteReader())
            {
                while (_reader.Read())
                {
                    Course course = new Course()
                    {
                        courseName = _reader.GetString(1),
                        rating = _reader.GetDecimal(2),
                        courseId = _reader.GetInt32(0)
                    };
                    _lst.Add(course);
                }
            }
            _connection.Close();
            return _lst;
        }
    }
}
