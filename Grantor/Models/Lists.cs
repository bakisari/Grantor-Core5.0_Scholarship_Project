using BussinesLayer.Concrete;
using DataAcessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.Models
{
    public class Lists
    {
        // Fakülte Listesi
        public List<SelectListItem> Fakulte()
        {

            FacultyManager fm = new FacultyManager(new EfFacultyRepository());
            List<SelectListItem> valuefaculty = (from x in fm.AllList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.FacultyName,
                                                     Value = x.FacultyID.ToString()
                                                 }).ToList();
            return valuefaculty;  
        }
        // Üniversite Listesi
        public List<SelectListItem> University()
        {
            UniversityManager um = new UniversityManager(new EfUniversityRepository());

            List<SelectListItem> valueuniversity = (from x in um.AllList()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.UniversityName,
                                                        Value = x.UniversityID.ToString()
                                                    }).ToList();
            return valueuniversity;
        }
        // Bölüm Listesi
        public List<SelectListItem> Sections()
        {
            SectionManager sem = new SectionManager(new EfSectionRepository());
            List<SelectListItem> valuesection = (from x in sem.AllList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.Name,
                                                     Value = x.SectionID.ToString()
                                                 }).ToList();
            return valuesection;

        }

        // Şehir Listesi
        public List<SelectListItem> Cities()
        {
            CityManager cm = new CityManager(new EfCityRepository());
            List<SelectListItem> valuecity= (from x in cm.AllList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CityName,
                                                      Value = x.CityID.ToString()
                                                  }).ToList();
            return valuecity;
        }
    }
}
