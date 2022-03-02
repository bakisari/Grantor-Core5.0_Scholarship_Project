using BussinesLayer.Concrete;
using DataAcessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.ViewComponents.Statistic
{
    public class Statistic : ViewComponent
    {
        StudentManager sm = new StudentManager(new EfStudentRepository());
        DonorManager dm = new DonorManager(new EfDonorRepository());
        public IViewComponentResult Invoke()
        {
            int totalstudent = sm.AllList().Count;
            double totalactivestudent = sm.AllList().Where(x => x.Active == true).Count();
            int countman = sm.AllList().Where(x => x.Gender == "Erkek").Where(y=>y.Active==true).Count();
            int countwoman = sm.AllList().Where(x => x.Gender == "Kadın").Where(y=>y.Active==true).Count();
            int countshowstudent = sm.AllList().Where(x => x.SiteShow == true).Count();
            int totaldonor =dm.AllList().Count;
            double totalstudentpercent = (totalactivestudent/totalstudent) *100;
            double totalmanpercent = (countman /totalactivestudent) *  100;
            double totalwomanpercent = (countwoman /totalactivestudent) *  100;
            ViewBag.totaldonor = totaldonor;
            ViewBag.totalstudent = totalactivestudent;
            ViewBag.totalshowstudent = countshowstudent;
            ViewBag.totalpercent = totalstudentpercent;
            ViewBag.womanpercent = totalwomanpercent;
            ViewBag.manpercent = totalmanpercent;

            return View();
        }
    }
}
