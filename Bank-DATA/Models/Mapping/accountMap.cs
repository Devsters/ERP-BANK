using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bank_DATA.Models.Mapping
{
    public class accountMap : EntityTypeConfiguration<account>
    {
        public accountMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.accountType)
                .HasMaxLength(255);

            this.Property(t => t.opnedDate)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("account", "bank");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.accountType).HasColumnName("accountType");
            this.Property(t => t.balance).HasColumnName("balance");
            this.Property(t => t.opnedDate).HasColumnName("opnedDate");
            this.Property(t => t.client_id).HasColumnName("client_id");

            // Relationships
            this.HasOptional(t => t.client)
                .WithMany(t => t.accounts)
                .HasForeignKey(d => d.client_id);

        }
    }
}
