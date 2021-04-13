// Anita Martin
// amartin98@cnm.edu
// WPF Data Demo

using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace WPFDemo
{
    class School
    {
        private List<string> course;
        private List<string> major;
        private List<string> campus;
        private List<Student> student;

        public List<string> Course
        {
            get { return course; }
            set { course = value; }
        }

        public List<string> Major
        {
            get { return major; }
            set { major = value; }
        }

        public List<string> Campus
        {
            get { return campus; }
            set { campus = value; }
        }

        public List<Student> Student
        {
            get { return student; }
            set { student = value; }
        }

        public School()
        {
            campus = GetData("SELECT * FROM Campus");
            course = GetData("SELECT * FROM Course");
            major = GetData("SELECT * FROM Major");
        }

        private List<string> GetData(string sqlStr)
        {
            List<string> items = new List<string>();
            string connStr = ConfigurationManager.ConnectionStrings["SchoolDB"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand selectCmd = new SqlCommand(sqlStr, conn);
                conn.Open();
                SqlDataReader dr = selectCmd.ExecuteReader();
                while (dr.Read())
                {
                    items.Add(dr.GetString(1));
                }
            }
            return items;
        }

    }

}
