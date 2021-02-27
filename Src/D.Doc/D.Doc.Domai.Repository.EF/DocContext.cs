using D.Doc.Domain.PO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace D.Doc.Domain.Repository
{
    public class DocContext : DbContext
    {
        public DocContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProjectCfg());
        }

        public DbSet<Project> Blogs { get; set; }
    }
}
