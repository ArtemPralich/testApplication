﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class Kind
    {
        [Column("KindId")]
        [Key]
        public int KindId { get; set; }
        public string Name { get; set; }
        public string About { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
