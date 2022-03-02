using DataAcessLayer.Abstract;
using DataAcessLayer.Repositories;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.EntityFramework
{
   public class EfFacultyRepository:GenericRepository<Faculty>,IFacultyDal
    {
    }
}
