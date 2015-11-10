using System;
using System.Collections.Generic;

namespace Bank_DATA.Models
{
    public partial class draft
    {
        public int id { get; set; }
        public float amount { get; set; }
        public string date { get; set; }
        public sbyte effect { get; set; }
        public string pay_date { get; set; }
        public string rib { get; set; }
        public string time { get; set; }
        public Nullable<int> account_id { get; set; }
        public virtual account account { get; set; }
    }
}
