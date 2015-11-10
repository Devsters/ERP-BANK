using System;
using System.Collections.Generic;

namespace Bank_DATA.Models
{
    public partial class client
    {
        public client()
        {
            this.accounts = new List<account>();
        }

        public int id { get; set; }
        public string birthDate { get; set; }
        public string email { get; set; }
        public string lastName { get; set; }
        public string login { get; set; }
        public string name { get; set; }
        public string passWord { get; set; }
        public string phoneNumber { get; set; }
        public string registrationDate { get; set; }
        public virtual ICollection<account> accounts { get; set; }
    }
}
