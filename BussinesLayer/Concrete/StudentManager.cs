using BussinesLayer.Abstract;
using DataAcessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
    public class StudentManager : IStudentService
    {
        IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public void Add(Student t)
        {
            _studentDal.Insert(t);
        }

        public List<Student> AllList()
        {
            return _studentDal.GetListAll();
        }

        public void Delete(Student student)
        {
            _studentDal.Delete(student);
        }

        public Student GetByID(int id)
        {
            return _studentDal.GetByID(id);
        }

        public Student GetStudent(string username, string password)
        {
            return _studentDal.Get(x => x.Mail == username && x.Password == password);
        }

        public void Update(Student t)
        {
            _studentDal.Update(t);
        }
    }
}
