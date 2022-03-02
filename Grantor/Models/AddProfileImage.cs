using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.Models
{
    public class AddProfileImage
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IFormFile Image { get; set; }
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
      
    }
}
