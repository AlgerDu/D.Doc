using D.Doc.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace D.Doc.Core
{
    public interface IEfContextFactory
    {
        DocContext Create();
    }
}
