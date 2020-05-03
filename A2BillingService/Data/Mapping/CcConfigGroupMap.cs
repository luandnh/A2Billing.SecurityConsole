using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Mapping
{
    public partial class CcConfigGroupMap
        : IEntityTypeConfiguration<A2BillingService.Data.Entities.CcConfigGroup>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<A2BillingService.Data.Entities.CcConfigGroup> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_config_group");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("int(11)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.GroupTitle)
                .IsRequired()
                .HasColumnName("group_title")
                .HasColumnType("varchar(64)")
                .HasMaxLength(64);

            builder.Property(t => t.GroupDescription)
                .IsRequired()
                .HasColumnName("group_description")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_config_group";

        public const string ColumnId = "id";
        public const string ColumnGroupTitle = "group_title";
        public const string ColumnGroupDescription = "group_description";
        #endregion
    }
}
