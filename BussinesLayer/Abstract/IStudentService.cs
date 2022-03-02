using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Abstract
{
  public  interface IStudentService:IGenericService<Student>
    {
        
        Student GetStudent(string username, string password);
        Student StudentChecked(string p);
        int IDCheck(string p);
        List<Student> StudentDetails();

    }
}
