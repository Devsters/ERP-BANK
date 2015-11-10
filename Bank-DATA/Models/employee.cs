using System;
using System.Collections.Generic;

namespace Bank_DATA.Models
{
    public partial class employee
    {
        public employee()
        {
            this.contracts = new List<contract>();
            this.payrolls = new List<payroll>();
        }

        public int id { get; set; }
        public string adress { get; set; }
        public string birthDate { get; set; }
        public int cin { get; set; }
        public string civilState { get; set; }
        public string email { get; set; }
        public int kidsNumber { get; set; }
        public string lastName { get; set; }
        public string name { get; set; }
        public string passWord { get; set; }
        public int phoneNumber { get; set; }
        public string role { get; set; }
        public string userName { get; set; }
        public Nullable<int> local_id { get; set; }
        public virtual ICollection<contract> contracts { get; set; }
        public virtual local local { get; set; }
        public virtual ICollection<payroll> payrolls { get; set; }
    }
}
