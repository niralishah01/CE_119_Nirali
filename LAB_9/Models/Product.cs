<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace wddn_lab9.Models
{
    public class Product
    {
        public int ID { get; set; }

        [Required]
        public string name { get; set; }

        [DataType("ntext")]
        public string details { get; set; }

        [Required]
        [Range(0,100000.00)]
        public decimal price { get; set; }

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
    public class Product
    {
        public int ID { get; set; }

        [Required]
        public string name { get; set; }

        [DataType("ntext")]
        public string details { get; set; }

        [Required]
        [Range(0,100000.00)]
        public decimal price { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
>>>>>>> ab94dfade7893148820be04f470ce8f209c59092
