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
    public class UniversityManager : IUniversityService
    {
        IUniversityDal _universityDal;

        public UniversityManager(IUniversityDal universityDal)
        {
            _universityDal = universityDal;
        }

        public void Add(University t)
        {
            _universityDal.Insert(t);
        }

        public List<University> AllList()
        {
          return  _universityDal.GetListAll();
        }

        public void Delete(University t)
        {
            _universityDal.Delete(t);
        }

        public University GetByID(int id)
        {
            return _universityDal.GetByID(id);
        }


        public void Update(University t)
        {
            _universityDal.Update(t);
        }
    }
}
