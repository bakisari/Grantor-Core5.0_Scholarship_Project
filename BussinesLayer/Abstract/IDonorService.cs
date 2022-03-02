using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Abstract
{
   public interface IDonorService:IGenericService<Donor>
    {
       
        Donor CheckDonor(string DonorMail);
        Donor GetDonor(string username, string password);
    }
}
