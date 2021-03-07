using D.Doc.Domain.PO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace D.Doc.Domain.Repository
{
    internal class DocTreePatternCfg : IEntityTypeConfiguration<DocTreePattern>
    {
        public void Configure(EntityTypeBuilder<DocTreePattern> builder)
        {
            builder.Ignore(c => c.PK);

            builder.ToTable("doc_tree_pattern");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("id");
            builder.Property(c => c.Code).HasColumnName("code");
            builder.Property(c => c.Description).HasColumnName("description");
            builder.Property(c => c.DocTreeRootId).HasColumnName("doc_tree_root_id");
        }
    }
}