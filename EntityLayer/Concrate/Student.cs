using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Image { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public bool SiteShow { get; set; }
        public string Gender { get; set; }
        public string IBAN { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreateDate { get; set; }
        public int? CityID { get; set; }
        public City City { get; set; }
        public int? UniversityID { get; set; }
        public University University { get; set; }

    }
}
