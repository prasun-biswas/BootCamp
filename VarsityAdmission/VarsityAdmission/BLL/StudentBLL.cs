using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarsityAdmission.DLL.DAO;
using VarsityAdmission.DLL.GateWay;

namespace VarsityAdmission.BLL
{
    class StudentBLL
    {
        StudentGateway aStudentGateway=new StudentGateway();
        public string save(Student aStudent)
        {
            if (aStudent.RegNO == "" || aStudent.Name == "" || aStudent.Email == "")
            {
                return "please fill up fields";
            }
            else
            {
                
                return aStudentGateway.Save(aStudent);
            }
            
        }

        public bool CheckRegNO(string regNo)
        {
            return aStudentGateway.CheckRegNO(regNo);
        }

        public List<Student> ShowStudentData()
        {
            return aStudentGateway.ShowStudentData();
        }
    }
}
