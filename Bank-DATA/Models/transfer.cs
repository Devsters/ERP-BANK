using System;
using System.Collections.Generic;

namespace Bank_DATA.Models
{
    public partial class transfer
    {
        public int id { get; set; }
        public float amount { get; set; }
        public string bic { get; set; }
        public DateTime date { get; set; }
        public bool effect { get; set; }
        public string iban { get; set; }
        public string nameFull { get; set; }
        public string rib { get; set; }
        public string time { get; set; }
        public Nullable<int> account_id { get; set; }
        public virtual account account { get; set; }
    }
}
