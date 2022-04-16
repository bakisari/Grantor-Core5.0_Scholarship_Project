using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.Models.ViewModels
{
    public class RoleViewModel
    {
        [Display(Name = "Role")]
        [Required(ErrorMessage = "Role İsmi Gereklidir")]
        public string Name { get; set; }
        public string Id { get; set; }
    }
}
