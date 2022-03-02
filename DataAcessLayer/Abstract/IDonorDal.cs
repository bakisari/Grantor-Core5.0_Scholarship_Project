﻿using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Abstract
{
   public interface IDonorDal:IGenericDal<Donor>
    {
        Donor DonorChecked(string p);
    }
}
