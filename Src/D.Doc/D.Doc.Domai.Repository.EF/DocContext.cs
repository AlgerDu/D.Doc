using D.Doc.Domain.PO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace D.Doc.Domain.Repository
{
    /// <summary>
    /// ef context for doc
    /// </summary>
    public class DocContext : DbContext
    {
        /// <summary>
        /// default
        /// </summary>
        /// <param name="options"></param>
        public DocContext(DbContextOptions options)
            : base(options)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProjectCfg());
        }

        /// <summary>
        /// 项目列表
        /// </summary>
        public DbSet<Project> Projects { get; set; }
    }
}
