using BussinesLayer.Concrete;
using DataAcessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.ViewComponents.Footer
{
    public class Footer:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            AdressManager adressManager = new AdressManager(new EfAdressRepository());
            var values = adressManager.AllList();
            return View(values);
        }
    }
}
