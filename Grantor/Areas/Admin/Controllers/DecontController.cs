using BussinesLayer.Concrete;
using DataAcessLayer.EntityFramework;
using EntityLayer.Concrate;
using Grantor.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class DecontController : Controller
    {
        DecontManager decontManager = new DecontManager(new EfDecontRepository());

        private IHostingEnvironment Environment;

        public DecontController(IHostingEnvironment _environment)
        {
            Environment = _environment;
        }
        public IActionResult Index()
        {
            //Fetch all files in the Folder (Directory).
            string[] filePaths = Directory.GetFiles(Path.Combine(this.Environment.WebRootPath, "Deconts/"));

            //Copy File names to Model collection.
            var deconts = decontManager.AllList();
            Decont dm = new Decont();
            List<Decont> files = new List<Decont>();
            foreach (string filePath in filePaths)
            {
                files.Add(new Decont {Value = Path.GetFileName(filePath) });
               
            }
            var values = files.OrderByDescending(x=>x.DecontID);

            ViewBag.files = values;
            return View(deconts);
        }
        public FileResult DownloadFile(string Value)
        {
            //Build the File Path.
            string path = Path.Combine(this.Environment.WebRootPath, "Deconts/") + Value;

            //Read the File data into Byte Array.
            byte[] bytes = System.IO.File.ReadAllBytes(path);

            //Send the File to Download.
            return File(bytes, "application/octet-stream", Value);
        }
    }
}
