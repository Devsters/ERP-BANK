using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bank_DATA.Models
{
    public partial class account
    {
        public account()
        {
            this.transactions = new List<transaction>();
            this.transfers = new List<transfer>();
            this.drafts = new List<draft>();
        }

        public int id { get; set; }
        public string accountType { get; set; }
        public float balance { get; set; }
        public string opnedDate { get; set; }
        public Nullable<int> client_id { get; set; }
        public virtual ICollection<transaction> transactions { get; set; }
        public virtual ICollection<transfer> transfers { get; set; }
        [UIHint("Autocomplete", null, "MinimumPrefixLength", 2)]
        public virtual client client { get; set; }
        public virtual ICollection<draft> drafts { get; set; }
    }
}
