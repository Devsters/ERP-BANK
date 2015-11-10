using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bank_DATA.Models.Mapping
{
    public class transferMap : EntityTypeConfiguration<transfer>
    {
        public transferMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.bic)
                .HasMaxLength(255);

            this.Property(t => t.date)
                .HasColumnType("datetime");

            this.Property(t => t.iban)
                .HasMaxLength(255);

            this.Property(t => t.nameFull)
                .HasMaxLength(255);

            this.Property(t => t.rib)
                .HasMaxLength(255);

            this.Property(t => t.time)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("transfer", "bank");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.amount).HasColumnName("amount");
            this.Property(t => t.bic).HasColumnName("bic");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.effect).HasColumnName("effect");
            this.Property(t => t.iban).HasColumnName("iban");
            this.Property(t => t.nameFull).HasColumnName("nameFull");
            this.Property(t => t.rib).HasColumnName("rib");
            this.Property(t => t.time).HasColumnName("time");
            this.Property(t => t.account_id).HasColumnName("account_id");

            // Relationships
            this.HasOptional(t => t.account)
                .WithMany(t => t.transfers)
                .HasForeignKey(d => d.account_id);

        }
    }
}
