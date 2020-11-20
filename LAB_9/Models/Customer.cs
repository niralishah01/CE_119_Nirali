<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace wddn_lab9.Models
{
    public class Customer
    {
        public int ID { get; set; }

        [Required]
        [StringLength(12,ErrorMessage ="Customer name can't be more than 12 chars.")]
        public string name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name ="Email Address")]
        public string email { get; set; }

        [Required]
        [RegularExpression(@"^\d{10}$",ErrorMessage ="Mobile no should contain exactly 10 digits")]
        public decimal Mobile_no { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace wddn_lab9.Models
{
    public class Customer
    {
        public int ID { get; set; }

        [Required]
        [StringLength(12,ErrorMessage ="Customer name can't be more than 12 chars.")]
        public string name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name ="Email Address")]
        public string email { get; set; }

        [Required]
        [RegularExpression(@"^\d{10}$",ErrorMessage ="Mobile no should contain exactly 10 digits")]
        public decimal Mobile_no { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
>>>>>>> ab94dfade7893148820be04f470ce8f209c59092
