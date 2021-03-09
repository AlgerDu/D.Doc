using D.Doc.Domain.Repository;
using D.Doc.Server.Models;
using D.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D.Doc.Server.Controllers
{
    [ApiController]
    public class PatternController : ControllerBase
    {
        readonly DocContext _context;

        public PatternController(
            DocContext context
            )
        {
            _context = context;
        }

        [HttpPost("api/projects/{project}/v/{version}/pattern")]
        public IResult AddOrUpdatePath(
            [FromRoute] string project
            , [FromRoute] string version
            , [FromBody] PatternAddOrUpdateModel model)
        {
            return Result.CreateSuccess();
        }
    }
}
