using BussinesLayer.Concrete;
using DataAcessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.Controllers
{
    public class GalleryController : Controller
    {
        GalleryManager gm = new GalleryManager(new EfGalleryRepository());
        public IActionResult Index()
        {
            var images = gm.AllList();
            return View(images);
        }
    }
}
