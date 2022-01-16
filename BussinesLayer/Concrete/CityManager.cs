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
    public class CityManager : ICityService
    {
        ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public void Add(City t)
        {
            _cityDal.Insert(t);
        }

        public List<City> AllList()
        {
            return _cityDal.GetListAll();
        }

        public void Delete(City t)
        {
            _cityDal.Delete(t);
        }

        public City GetByID(int id)
        {
            return _cityDal.GetByID(id);
        }

       

        public void Update(City t)
        {
            _cityDal.Update(t);
        }
    }
}
