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
    public class SectionManager : ISectionService
    {
        ISectionDal _sectionDal;

        public SectionManager(ISectionDal sectionDal)
        {
            _sectionDal = sectionDal;
        }

        public void Add(Section t)
        {
            _sectionDal.Insert(t);
        }

        public List<Section> AllList()
        {
            return _sectionDal.GetListAll();
        }

        public void Delete(Section t)
        {
            _sectionDal.Delete(t);
        }

        public Section GetByID(int id)
        {
            return _sectionDal.GetByID(id);
        }

        public void Update(Section t)
        {
            _sectionDal.Update(t);
        }
    }
}
