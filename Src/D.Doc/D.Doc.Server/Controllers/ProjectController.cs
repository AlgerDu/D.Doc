using D.Doc.Domain.PO;
using D.Doc.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D.Doc.Server.Controllers
{

    [ApiController]
    [Route("api/[controller]s")]
    public class ProjectController : ControllerBase
    {
        readonly DocContext _context;

        public ProjectController(
            DocContext context
            )
        {
            _context = context;
        }

        public IEnumerable<Project> Get()
        {
            return _context.Projects;
        }
    }
}
