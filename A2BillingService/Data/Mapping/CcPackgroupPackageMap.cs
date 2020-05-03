using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Mapping
{
    public partial class CcPackgroupPackageMap
        : IEntityTypeConfiguration<A2BillingService.Data.Entities.CcPackgroupPackage>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<A2BillingService.Data.Entities.CcPackgroupPackage> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_packgroup_package");

            // key
            builder.HasKey(t => new { t.PackagegroupId, t.PackageId });

            // properties
            builder.Property(t => t.PackagegroupId)
                .IsRequired()
                .HasColumnName("packagegroup_id")
                .HasColumnType("int(11)");

            builder.Property(t => t.PackageId)
                .IsRequired()
                .HasColumnName("package_id")
                .HasColumnType("int(11)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_packgroup_package";

        public const string ColumnPackagegroupId = "packagegroup_id";
        public const string ColumnPackageId = "package_id";
        #endregion
    }
}
