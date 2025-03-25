﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public partial class Customer
    {
        [Key, Column("id", TypeName = "nvarchar(450)")]
        public string Id { get; set; }

        [Required]
        [Column("firstName")]
        public string? FirstName { get; set; }

        [Required, Column("lastName")]
        public string? LastName { get; set; }

        [Required, Column("phoneNumber", TypeName = "char(12)")]
        public string? PhoneNumber { get; set; }

        [Column("whatsapp", TypeName = "char(14)")]
        public string? Whatsapp { get; set; }

        [Column("Country")]
        public string? Country { get; set; }
    }
}
