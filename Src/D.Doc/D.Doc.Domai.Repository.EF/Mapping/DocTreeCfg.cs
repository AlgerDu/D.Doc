using D.Doc.Domain.PO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace D.Doc.Domain.Repository
{
    internal class DocTreeCfg : IEntityTypeConfiguration<DocTree>
    {
        public void Configure(EntityTypeBuilder<DocTree> builder)
        {
            builder.Ignore(c => c.PK);

            builder.ToTable("doc_tree");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("id");
            builder.Property(c => c.ParentId).HasColumnName("parent_id");
            builder.Property(c => c.Releation).HasColumnName("releation");
            builder.Property(c => c.DocBid).HasColumnName("doc_bid");
            builder.Property(c => c.StartTime).HasColumnName("start_time");
            builder.Property(c => c.EndTime).HasColumnName("end_time");
        }
    }
}