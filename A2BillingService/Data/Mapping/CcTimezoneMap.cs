using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Mapping
{
    public partial class CcTimezoneMap
        : IEntityTypeConfiguration<A2BillingService.Data.Entities.CcTimezone>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<A2BillingService.Data.Entities.CcTimezone> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_timezone");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("int(11)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Gmtzone)
                .HasColumnName("gmtzone")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Gmttime)
                .HasColumnName("gmttime")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Gmtoffset)
                .IsRequired()
                .HasColumnName("gmtoffset")
                .HasColumnType("bigint(20)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_timezone";

        public const string ColumnId = "id";
        public const string ColumnGmtzone = "gmtzone";
        public const string ColumnGmttime = "gmttime";
        public const string ColumnGmtoffset = "gmtoffset";
        #endregion
    }
}
