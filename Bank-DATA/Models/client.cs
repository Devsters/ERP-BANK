using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bank_DATA.Models
{
    public partial class client
    {
        public client()
        {
            this.accounts = new List<account>();
        }

        public int id { get; set; }
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime birthDate { get; set; }
        public string email { get; set; }
        public string lastName { get; set; }
        public string login { get; set; }
        public string name { get; set; }
        public string passWord { get; set; }
        public string phoneNumber { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString =
      "{0:yyyy-MM-dd}",
       ApplyFormatInEditMode = true)]
        public DateTime registrationDate { get; set; }
        public virtual ICollection<account> accounts { get; set; }
    }
}
