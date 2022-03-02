using System;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
   public class Gallery
    {
        [Key]
        public int ImageID { get; set; }
        public string ImageUrl { get; set; }
        public string ImageDescription { get; set; }
    }
}
