using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarsityAdmission.DLL.DAO;

namespace VarsityAdmission.DLL.GateWay
{
    class CourseGateway
    {
        private SqlConnection connection;
        private List<Course> showCourseData;
        private Course aCourse;
        public CourseGateway()
        {
            string connect = @"server=ASHIQ; database=VarsityAdmissionDB; integrated security=true";
            connection = new SqlConnection();
            connection.ConnectionString = connect;
        }
        public List<Course> ShowCourseData()
        {
            connection.Open();
            string query = string.Format("SELECT * FROM t_Course");

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            showCourseData= new List<Course>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    aCourse = new Course();
                    aCourse.CourseName = aReader[0].ToString();
                    aCourse.CourseTitle = aReader[1].ToString();
                    showCourseData.Add(aCourse);
                }
            }
            connection.Close();
            return showCourseData;

        }
    }
}
