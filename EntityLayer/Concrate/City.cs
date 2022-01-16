using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
   public class City
    {
        [Key]
        public int? CityID { get; set; }
        public string CityName { get; set; }
        public  bool Deleted { get; set; }
        public List<Student> Students { get; set; }
    }
}
