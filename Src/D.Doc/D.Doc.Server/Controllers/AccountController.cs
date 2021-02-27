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
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        readonly DocContext _context;

        public AccountController(
            DocContext context
            )
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Project> Get()
        {
            return _context.Projects;
        }

        [HttpPost]
        public IEnumerable<Project> Get2()
        {
            return _context.Projects;
        }
    }
}
