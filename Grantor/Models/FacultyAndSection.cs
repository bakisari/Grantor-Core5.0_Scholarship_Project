using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.Models
{
    public class FacultyAndSection
    {
        public IEnumerable<SelectListItem>Facultys { get; set; }
        public IEnumerable<SelectListItem>Sections { get; set; }
    }
}
