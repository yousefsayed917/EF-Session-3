using Assignment.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Configration
{
    public class TopicConfigration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn(10, 10);
            builder.Property(p => p.Name).HasColumnName("TopicName")
                   .HasColumnType("Varchar").HasMaxLength(50);

        }
    }
}

