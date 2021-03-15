using D.Doc.Domain.PO;
using D.Doc.Domain.Repository;
using D.Doc.Server.Models;
using D.Utils;
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IResult<long> PostProject([FromBody] AddProjectModel model)
        {
            var id = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            var project = new Project()
            {
                Id = id++,
                Name = model.Name,
                Description = model.Description
            };

            var version = new ProjectVersion()
            {
                Id = id++,
                Name = model.InitVersion.Name,
                Description = model.InitVersion.Description
            };

            project.CurrVersionId = version.Id;
            version.ProjectId = project.Id;

            _context.Projects.Add(project);
            _context.ProjectVersions.Add(version);

            _context.SaveChanges();

            return Result.CreateSuccess<long>(id);
        }

        public IEnumerable<Project> Get()
        {
            return _context.Projects;
        }
    }
}
