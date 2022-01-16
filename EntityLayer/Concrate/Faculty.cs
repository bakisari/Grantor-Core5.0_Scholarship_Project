using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Faculty
    {
        public int FacultyID { get; set; }
        public string FacultyName { get; set; }
        public bool Deleted { get; set; }
        public bool Active { get; set; }
        public List<University> Universities { get; set; }

    }
}
