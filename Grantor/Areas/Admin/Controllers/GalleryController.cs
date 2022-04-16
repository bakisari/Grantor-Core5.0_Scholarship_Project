using BussinesLayer.Concrete;
using DataAcessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class GalleryController : Controller
    {
        GalleryManager galleryManager = new GalleryManager(new EfGalleryRepository());
        public IActionResult Index()
        {
            var values = galleryManager.AllList();
            return View(values);
        }
    }
}
