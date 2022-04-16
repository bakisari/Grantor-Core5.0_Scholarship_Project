using BussinesLayer.Concrete;
using DataAcessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.Controllers
{
    public class FaqController : Controller
    {
        FaqManager faqManager = new FaqManager(new EfFaqRepository());
        public IActionResult SSS()
        {
            var values = faqManager.AllList();
            return View(values);
        }
    }
}
