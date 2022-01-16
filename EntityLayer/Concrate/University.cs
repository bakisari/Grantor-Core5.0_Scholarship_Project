using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class University
    {
        [Key]
        public int? UniversityID { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public string UniversityName { get; set; }
        public List<Student> Students { get; set; }
        public List<Faculty> Faculties { get; set; }
    }
}
