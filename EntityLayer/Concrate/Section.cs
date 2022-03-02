using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Section
    {
        [Key]
        public int? SectionID { get; set; }
        public string Name { get; set; }
        public int? FacultyID { get; set; }
        public Faculty Faculty { get; set; }
    }
}
