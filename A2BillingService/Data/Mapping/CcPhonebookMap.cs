using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace A2BillingService.Data.Mapping
{
    public partial class CcPhonebookMap
        : IEntityTypeConfiguration<A2BillingService.Data.Entities.CcPhonebook>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<A2BillingService.Data.Entities.CcPhonebook> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("cc_phonebook");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("id")
                .HasColumnType("int(11)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasColumnType("char(30)")
                .HasMaxLength(30);

            builder.Property(t => t.Description)
                .HasColumnName("description")
                .HasColumnType("mediumtext");

            builder.Property(t => t.IdCard)
                .IsRequired()
                .HasColumnName("id_card")
                .HasColumnType("bigint(20)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public const string TableSchema = "";
        public const string TableName = "cc_phonebook";

        public const string ColumnId = "id";
        public const string ColumnName = "name";
        public const string ColumnDescription = "description";
        public const string ColumnIdCard = "id_card";
        #endregion
    }
}
