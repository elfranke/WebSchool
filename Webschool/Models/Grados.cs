using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webschool.Models
{
    public class Grados
    {
        public static List<SelectListItem> Gradoes { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "1ro" },
            new SelectListItem { Value = "2", Text = "2do" },
            new SelectListItem { Value = "3", Text = "3ro"  },
            new SelectListItem { Value = "4", Text = "4to" },
            new SelectListItem { Value = "5", Text = "5to" },
            new SelectListItem { Value = "6", Text = "6to"  },
        };
    }
}
