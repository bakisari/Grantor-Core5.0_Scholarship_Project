using EntityLayer.Concrate;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.Models
{
    public class AppUser:IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Image { get; set; }
        public bool SiteShow { get; set; }
        public string Gender { get; set; }
        public string IBAN { get; set; }
        public string FamilyMaritalStatus { get; set; }
        public string FamilyDeathStatus { get; set; }
        public string FamilyWorkStatus { get; set; }
        public string PhyscialDisability { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreateDate { get; set; }
        public int? CityID { get; set; }
        public City City { get; set; }
        public int? UniversityID { get; set; }
        public University University { get; set; }
        public int? FacultyID { get; set; }
        public Faculty Faculty { get; set; }
        public int? SectionID { get; set; }
        public Section Section { get; set; }
    }
}
