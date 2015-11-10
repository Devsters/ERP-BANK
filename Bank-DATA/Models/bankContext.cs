using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Bank_DATA.Models.Mapping;

namespace Bank_DATA.Models
{
    public partial class bankContext : DbContext
    {
        static bankContext()
        {
            Database.SetInitializer<bankContext>(null);
        }

        public bankContext()
            : base("Name=bankContext")
        {
        }

        public IDbSet<account> accounts { get; set; }
        public IDbSet<candidature> candidatures { get; set; }
        public IDbSet<client> clients { get; set; }
        public IDbSet<contract> contracts { get; set; }
        public IDbSet<draft> drafts { get; set; }
        public IDbSet<employee> employees { get; set; }
        public IDbSet<local> locals { get; set; }
        public IDbSet<material> materials { get; set; }
        public IDbSet<meeting> meetings { get; set; }
        public IDbSet<payroll> payrolls { get; set; }
        public IDbSet<supplier> suppliers { get; set; }
        public IDbSet<transaction> transactions { get; set; }
        public IDbSet<transfer> transfers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new accountMap());
            modelBuilder.Configurations.Add(new candidatureMap());
            modelBuilder.Configurations.Add(new clientMap());
            modelBuilder.Configurations.Add(new contractMap());
            modelBuilder.Configurations.Add(new draftMap());
            modelBuilder.Configurations.Add(new employeeMap());
            modelBuilder.Configurations.Add(new localMap());
            modelBuilder.Configurations.Add(new materialMap());
            modelBuilder.Configurations.Add(new meetingMap());
            modelBuilder.Configurations.Add(new payrollMap());
            modelBuilder.Configurations.Add(new supplierMap());
            modelBuilder.Configurations.Add(new transactionMap());
            modelBuilder.Configurations.Add(new transferMap());
        }
    }
}
