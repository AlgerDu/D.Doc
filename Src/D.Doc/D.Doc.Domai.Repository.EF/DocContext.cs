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
            modelBuilder.ApplyConfiguration(new ProjectVersionCfg());

            modelBuilder.ApplyConfiguration(new DocumentCfg());
            modelBuilder.ApplyConfiguration(new DocTreeCfg());
            modelBuilder.ApplyConfiguration(new DocTreePatternCfg());
        }

        /// <summary>
        /// 项目列表
        /// </summary>
        public DbSet<Project> Projects { get; set; }

        /// <summary>
        /// 项目的版本
        /// </summary>
        public DbSet<ProjectVersion> ProjectVersions { get; set; }

        /// <summary>
        /// 文档
        /// </summary>
        public DbSet<Document> Docs { get; set; }

        /// <summary>
        /// 文档树
        /// </summary>
        public DbSet<DocTree> DocTrees { get; set; }

        /// <summary>
        /// 文档树模板
        /// </summary>
        public DbSet<DocTreePattern> DocTreePatterns { get; set; }
    }
}
