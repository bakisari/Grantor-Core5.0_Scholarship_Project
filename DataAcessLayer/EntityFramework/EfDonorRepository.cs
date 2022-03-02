using DataAcessLayer.Abstract;
using DataAcessLayer.Concrete;
using DataAcessLayer.Repositories;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.EntityFramework
{
    public class EfDonorRepository : GenericRepository<Donor>, IDonorDal
    {
       //** The code that checks whether the donor has been registered in the system before **//
        public Donor DonorChecked(string p)
        {
            using var c = new Context();
           var checkvalue = c.Donors.Where(x => x.Mail == p).FirstOrDefault();
            return checkvalue;
        }
    }
}
