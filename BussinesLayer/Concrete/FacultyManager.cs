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
    public class FacultyManager : IFacultyService
    {
        IFacultyDal _faculyDal;

        public FacultyManager(IFacultyDal faculyDal)
        {
            _faculyDal = faculyDal;
        }

        public void Add(Faculty t)
        {
            _faculyDal.Insert(t);
        }

        public List<Faculty> AllList()
        {
           return _faculyDal.GetListAll();
        }

        public void Delete(Faculty t)
        {
            _faculyDal.Delete(t);
        }

        public Faculty GetByID(int id)
        {
            return _faculyDal.GetByID(id);
        }

        public void Update(Faculty t)
        {
            _faculyDal.Update(t);
        }
    }
}
