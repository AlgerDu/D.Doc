using D.Doc.Domain.PO;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace D.Doc.Core
{
    public class DomainProject : IProject
    {
        readonly ILogger _logger;
        readonly IEfContextFactory _contextFactory;

        readonly Project _db;

        readonly List<IProjectVersion> _versions;

        #region IProject 属性
        public long PK => _db.PK;

        public string Name { get => _db.Name; set => _db.Name = value; }

        public string Description { get => _db.Description; set => _db.Description = value; }

        public IProjectVersion CurrentVersion => _versions.FirstOrDefault(vv => vv.PK == _db.CurrVersionId);

        public IEnumerable<IProjectVersion> Versions => _versions;
        #endregion

        public DomainProject(
            ILogger<DomainProject> logger
            , IEfContextFactory contextFactory
            , Project db
            )
        {
            _logger = logger;
            _contextFactory = contextFactory;
            _db = db;
        }

        public bool IsTransient()
        {
            return _db.IsTransient();
        }

        private void LoadAllVsersion()
        {

        }
    }
}
