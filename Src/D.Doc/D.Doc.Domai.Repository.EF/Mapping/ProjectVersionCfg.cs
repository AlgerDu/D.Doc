using D.Doc.Domain.PO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace D.Doc.Domain.Repository
{
    internal class ProjectVersionCfg : IEntityTypeConfiguration<ProjectVersion>
    {
        public void Configure(EntityTypeBuilder<ProjectVersion> builder)
        {
            builder.Ignore(c => c.PK);

            builder.ToTable("project_version");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("id");
            builder.Property(c => c.Code).HasColumnName("code");
            builder.Property(c => c.Description).HasColumnName("description");

            builder.Property(c => c.ProjectId).HasColumnName("project_id");
            builder.Property(c => c.BaseVersionId).HasColumnName("base_version_id");
            builder.Property(c => c.PatternRootId).HasColumnName("pattern_root_id");
            builder.Property(c => c.DocTreeRootId).HasColumnName("doc_tree_root_id");

            builder.Property(c => c.IsStable).HasColumnName("is_stable");
            builder.Property(c => c.IsDelete).HasColumnName("is_delete");
        }
    }
}
