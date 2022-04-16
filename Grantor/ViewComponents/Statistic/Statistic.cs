using BussinesLayer.Concrete;
using DataAcessLayer.EntityFramework;
using Grantor.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.ViewComponents.Statistic
{
    public class Statistic : ViewComponent
    {
        StUserManager sm = new StUserManager(new EfUserRepository());
        //   DonorManager dm = new DonorManager(new EfDonorRepository());
        UserManager<AppUser> userManager { get; }
         RoleManager<AppRole> roleManager { get; }
        public Statistic(RoleManager<AppRole> roleManager,UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }
        public IViewComponentResult Invoke()
        {
            int totalstudent = sm.AllList().Count;
            double totalactivestudent = sm.AllList().Where(x => x.Active == true).Count();
            int countman = sm.AllList().Where(x => x.Gender == "Erkek").Where(y=>y.Active==true).Count();
            int countwoman = sm.AllList().Where(x => x.Gender == "Kadın").Where(y=>y.Active==true).Count();
            int countshowstudent = sm.AllList().Where(x => x.SiteShow == true).Count();
            
            double totalstudentpercent = (totalactivestudent/totalstudent) *100;
            double totalmanpercent = (countman /totalactivestudent) *  100;
            double totalwomanpercent = (countwoman /totalactivestudent) *  100;
           // ViewBag.totaldonor = totaldonor;
            ViewBag.totalstudent = totalactivestudent;
            ViewBag.totalshowstudent = countshowstudent;
            ViewBag.totalpercent = totalstudentpercent;
            ViewBag.womanpercent = totalwomanpercent;
            ViewBag.manpercent = totalmanpercent;

            return View();
        }
    }
}
