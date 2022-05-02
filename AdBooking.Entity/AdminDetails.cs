using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdBooking.Entity
{
    public class AdminDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdminID { get; set; }
        public string AdminName { get; set; }
        public string AdminMail { get; set; }
        public string AdminPassword { get; set; }
    }
}
