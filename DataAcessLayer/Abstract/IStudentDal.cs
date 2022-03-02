using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Abstract
{
    public interface IStudentDal:IGenericDal<Student>
    {
        IEnumerable<Student> GetStudentFilters(string Gender = null, string University=null,string Faculty=null,string Section=null, string MarriageStatus = null, string DeathStatus = null, string WorkStatus = null, string PhysicalDisablty = null);
        Student CheckStudent(string mail);
        int CheckedID(string p);
        List<Student> GetListStudentDetails();
    }
}
