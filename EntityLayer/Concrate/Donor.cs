using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Donor
    {
        [Key]
        public int DonorID { get; set; }
        public string DonorName { get; set; }
        public string DonorMail { get; set; }
        public string DonorPhone { get; set; }
        public string DonorPassword { get; set; }
        public string DonorImage { get; set; }
        public bool Deleted { get; set; }
        public bool Active { get; set; }
    }
}
