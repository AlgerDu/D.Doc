using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace D.Doc.Server.Models
{
    public class RouteProjectModel
    {
        [Required]
        [FromRoute]
        public string Project { get; set; }

        [Required]
        [FromRoute]
        public string Version { get; set; }
    }
}
