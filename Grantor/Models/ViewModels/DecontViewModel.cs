using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.Models.ViewModels
{
    public class DecontViewModel
    {
        public int DecontID { get; set; }
        public string Value { get; set; }
        public int SenderID { get; set; }
        public int ReceiverID { get; set; }
        public AppUser SenderUser { get; set; }
        public AppUser ReceiverUser { get; set; }
        public IFormFile Image { get; set; }

    }

}
