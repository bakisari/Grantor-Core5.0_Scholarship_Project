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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Add(About t)
        {
            _aboutDal.Insert(t);
        }


        public List<About> AllList()
        {
            return _aboutDal.GetListAll();
        }

        public void Delete(About t)
        {
            _aboutDal.Delete(t);
        }

        public List<About> GetAboutCheck()
        {
            return _aboutDal.GetListAll(x => x.Active == true);
        }

        public About GetByID(int id)
        {
            return _aboutDal.GetByID(id);
        }
    

        public void Update(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
