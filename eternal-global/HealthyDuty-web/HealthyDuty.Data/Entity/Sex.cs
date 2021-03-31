﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HealthyDuty.Data.Entity
{
    [Table("Sex")]
    public class Sex
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

    }
}
