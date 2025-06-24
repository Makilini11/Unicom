using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Data;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Controllers
{
    internal class CourseController
    {
        public static void AddCourse(string name)
        {
            using (var conn = DatabaseManager.GetConnection())
            {
                var cmd = new SQLiteCommand("INSERT INTO Courses (CourseName) VALUES (@name)", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.ExecuteNonQuery();
            }
        }

        public static List<Course> GetCourses()
        {
            var courses = new List<Course>();
            using (var conn = DatabaseManager.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Courses", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        courses.Add(new Course
                        {
                            CourseID = reader.GetInt32(0),
                            CourseName = reader.GetString(1)
                        });
                    }
                }
            }
            return courses;
        }
        public static void UpdateCourse(int id, string name)
        {
            var conn = DatabaseManager.GetConnection();
            conn.Open();
            var cmd = new SQLiteCommand("UPDATE Courses SET CourseName = @name WHERE CourseID = @id", conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public static void DeleteCourse(int id)
        {
            var conn = DatabaseManager.GetConnection();
            conn.Open();
            var cmd = new SQLiteCommand("DELETE FROM Courses WHERE CourseID = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }

}

