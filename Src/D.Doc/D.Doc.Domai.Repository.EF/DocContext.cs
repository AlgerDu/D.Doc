using D.Doc.Domain.PO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
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
        readonly DocContextOptions _options;

        /// <summary>
        /// 
        /// </summary>
        public DocContext(
            IOptionsSnapshot<DocContextOptions> options
            )
        {
            _options = options.Value;
        }

        /// <summary>
        /// optionsBuilder
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_options.ConnectionStrings);
        }

        /// <summary>
        /// OnModelCreating
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
