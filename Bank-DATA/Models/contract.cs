using System;
using System.Collections.Generic;

namespace Bank_DATA.Models
{
    public partial class contract
    {
        public int id { get; set; }
        public string contractType { get; set; }
        public string endDate { get; set; }
        public string startDate { get; set; }
        public Nullable<int> employee_id { get; set; }
        public virtual employee employee { get; set; }
    }
}
