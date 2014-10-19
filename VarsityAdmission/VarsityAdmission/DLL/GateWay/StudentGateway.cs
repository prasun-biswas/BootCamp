using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VarsityAdmission.DLL.DAO;

namespace VarsityAdmission.DLL.GateWay
{
    class StudentGateway
    {
        private SqlConnection connection;
        private List<Student> showStudentData;
        private Student aStudent;

        public StudentGateway()
        {
            string connect = @"server=ASHIQ; database=VarsityAdmissionDB; integrated security=true";
            connection = new SqlConnection();
            connection.ConnectionString = connect;
        }
        public string Save(Student aStudent)
        {
           
            connection.Open();
            string query = string.Format("INSERT INTO t_Student VALUES('{0}','{1}','{2}')",aStudent.RegNO,aStudent.Name,aStudent.Email);
            
            SqlCommand command=new SqlCommand(query,connection);
            int affectedrow = command.ExecuteNonQuery();
            connection.Close();
            if (affectedrow > 0)
            {
                return "enrolled";
            }
            else
            {
                return "something wrong";
            }
        }


        public bool CheckRegNO(string regNo)
        {
           
            connection.Open();
            string query = string.Format("SELECT * FROM t_Student WHERE RegNo='{0}'",regNo);

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            bool hasrow = aReader.HasRows;
            connection.Close();
            if (hasrow)
            {
                return true;
            }
            return false;
        }

        public List<Student> ShowStudentData()
        {

            connection.Open();
            string query = string.Format("SELECT * FROM t_Student");

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            showStudentData = new List<Student>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    aStudent = new Student();
                    aStudent.RegNO = aReader[0].ToString();
                    aStudent.Name = aReader[1].ToString();
                    aStudent.Email = aReader[2].ToString();
                    showStudentData.Add(aStudent);
                }
            }
            connection.Close();
            return showStudentData;

        }
    }
}
