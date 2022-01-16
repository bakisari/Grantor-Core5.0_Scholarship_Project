using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
   public class About
    {
        [Key]
        public int ID { get; set; }
        public string AboutDetails1 { get; set; }
        public string AboutImage1 { get; set; }
        public string AboutStatus { get; set; }
        public bool Deleted { get; set; }
        public bool Active { get; set; }
    }
}
