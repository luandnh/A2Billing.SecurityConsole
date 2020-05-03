using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Mapping
{
    public partial class CcVersionMap
        : IEntityTypeConfiguration<A2BillingService.Data.Entities.CcVersion>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<A2BillingService.Data.Entities.CcVersion> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_version");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.Version)
                .IsRequired()
                .HasColumnName("version")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_version";

        public const string ColumnVersion = "version";
        #endregion
    }
}
