using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bank_DATA.Models.Mapping
{
    public class employeeMap : EntityTypeConfiguration<employee>
    {
        public employeeMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.adress)
                .HasMaxLength(255);

            this.Property(t => t.birthDate)
                .HasMaxLength(255);

            this.Property(t => t.civilState)
                .HasMaxLength(255);

            this.Property(t => t.email)
                .HasMaxLength(255);

            this.Property(t => t.lastName)
                .HasMaxLength(255);

            this.Property(t => t.name)
                .HasMaxLength(255);

            this.Property(t => t.passWord)
                .HasMaxLength(255);

            this.Property(t => t.role)
                .HasMaxLength(255);

            this.Property(t => t.userName)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("employee", "bank");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.adress).HasColumnName("adress");
            this.Property(t => t.birthDate).HasColumnName("birthDate");
            this.Property(t => t.cin).HasColumnName("cin");
            this.Property(t => t.civilState).HasColumnName("civilState");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.kidsNumber).HasColumnName("kidsNumber");
            this.Property(t => t.lastName).HasColumnName("lastName");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.passWord).HasColumnName("passWord");
            this.Property(t => t.phoneNumber).HasColumnName("phoneNumber");
            this.Property(t => t.role).HasColumnName("role");
            this.Property(t => t.userName).HasColumnName("userName");
            this.Property(t => t.local_id).HasColumnName("local_id");

            // Relationships
            this.HasOptional(t => t.local)
                .WithMany(t => t.employees)
                .HasForeignKey(d => d.local_id);

        }
    }
}
