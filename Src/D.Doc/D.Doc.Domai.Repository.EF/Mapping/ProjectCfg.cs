using D.Doc.Domain.PO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace D.Doc.Domain.Repository
{
    internal class ProjectCfg : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.Ignore(c => c.PK);

            builder.ToTable("project");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("id");
            builder.Property(c => c.Name).HasColumnName("name");
            builder.Property(c => c.Description).HasColumnName("description");
            builder.Property(c => c.CurrVersionID).HasColumnName("curr_version_id");
            builder.Property(c => c.IsDelete).HasColumnName("is_delete");
        }
    }
}
