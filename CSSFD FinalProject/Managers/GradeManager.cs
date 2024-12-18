using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace CSSFD_FinalProject.Managers
{
    public class GradeManager
    {
        private readonly string connectionString = "Server=127.0.0.1;Database=studentdb;User ID=root;Password=;";

        public DataTable GetGrades(string studentNumber, int year)
        {
            DataTable table = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT subject_name AS 'Subject', grade AS 'Grade' FROM grades WHERE student_number = @studentNumber AND year = @year";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentNumber", studentNumber);
                    cmd.Parameters.AddWithValue("@year", year);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(table);
                }
            }

            return table;
        }

        public bool AddGrade(string studentNumber, string subjectName, decimal grade, int year)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO grades (student_number, subject_name, grade, year) VALUES (@studentNumber, @subjectName, @grade, @year)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentNumber", studentNumber);
                    cmd.Parameters.AddWithValue("@subjectName", subjectName);
                    cmd.Parameters.AddWithValue("@grade", grade);
                    cmd.Parameters.AddWithValue("@year", year);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool UpdateGrade(string studentNumber, string subjectName, decimal grade, int year)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "UPDATE grades SET grade = @grade WHERE student_number = @studentNumber AND subject_name = @subjectName AND year = @year";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentNumber", studentNumber);
                    cmd.Parameters.AddWithValue("@subjectName", subjectName);
                    cmd.Parameters.AddWithValue("@grade", grade);
                    cmd.Parameters.AddWithValue("@year", year);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool DeleteGrade(string studentNumber, string subjectName, int year)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "DELETE FROM grades WHERE student_number = @studentNumber AND subject_name = @subjectName AND year = @year";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@studentNumber", studentNumber);
                    cmd.Parameters.AddWithValue("@subjectName", subjectName);
                    cmd.Parameters.AddWithValue("@year", year);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
