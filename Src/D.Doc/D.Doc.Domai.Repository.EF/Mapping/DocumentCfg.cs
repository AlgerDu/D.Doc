using D.Doc.Domain.PO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace D.Doc.Domain.Repository
{
    internal class DocumentCfg : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.Ignore(c => c.PK);

            builder.ToTable("document");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("id");
            builder.Property(c => c.Name).HasColumnName("name");
            builder.Property(c => c.Bid).HasColumnName("bid");
            builder.Property(c => c.Data).HasColumnName("data");
            builder.Property(c => c.MetadataTreeId).HasColumnName("metadata_tree_id");
        }
    }
}