using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarsityAdmission.DLL.DAO;
using VarsityAdmission.DLL.GateWay;

namespace VarsityAdmission.BLL
{
    class CourseBLL
    {
        CourseGateway aCourseGateway=new CourseGateway();
        public List<Course> ShowCourseData()
        {
            return aCourseGateway.ShowCourseData();
        }
    }
}
