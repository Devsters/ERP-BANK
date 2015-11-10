using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bank_DATA.Models.Mapping
{
    public class clientMap : EntityTypeConfiguration<client>
    {
        public clientMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.birthDate)
                .HasMaxLength(255);

            this.Property(t => t.email)
                .HasMaxLength(255);

            this.Property(t => t.lastName)
                .HasMaxLength(255);

            this.Property(t => t.login)
                .HasMaxLength(255);

            this.Property(t => t.name)
                .HasMaxLength(255);

            this.Property(t => t.passWord)
                .HasMaxLength(255);

            this.Property(t => t.phoneNumber)
                .HasMaxLength(255);

            this.Property(t => t.registrationDate)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("client", "bank");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.birthDate).HasColumnName("birthDate");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.lastName).HasColumnName("lastName");
            this.Property(t => t.login).HasColumnName("login");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.passWord).HasColumnName("passWord");
            this.Property(t => t.phoneNumber).HasColumnName("phoneNumber");
            this.Property(t => t.registrationDate).HasColumnName("registrationDate");
        }
    }
}
