using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Faculty
    {
        [Key]
        public int? FacultyID { get; set; }
        public string FacultyName { get; set; }
        public bool Deleted { get; set; }
        public bool Active { get; set; }
        public List<Section> Sections { get; set; }

    }
}
