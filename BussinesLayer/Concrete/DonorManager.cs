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
    public class DonorManager : IDonorService
    {
        IDonorDal _donorDal;

        public DonorManager(IDonorDal donorDal)
        {
            _donorDal = donorDal;
        }

        public void Add(Donor donor)
        {
            _donorDal.Insert(donor);
        }

        public List<Donor> AllList()
        {
            return _donorDal.GetListAll();
        }

        public Donor CheckDonor(string DonorMail)
        {
            return _donorDal.DonorChecked(DonorMail);
        }

        public void Delete(Donor donor)
        {
            _donorDal.Delete(donor);
        }

        public Donor GetByID(int id)
        {
            return _donorDal.GetByID(id);
        }

        public Donor GetDonor(string username, string password)
        {
            return _donorDal.Get(x => x.Mail == username && x.Password == password);
        }

        public void Update(Donor donor)
        {
            _donorDal.Update(donor);
        }
    }
}
