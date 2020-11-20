<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace wddn_lab9.Models
{
    public class Order
    {
        public int ID { get; set; }

        public int Cust_ID { get; set; }
        public Customer Customer { get; set; }

        public int P_ID { get; set; }
        public Product Product { get; set; }

        [Range(0,100000.00)]
        public decimal Amount { get; set; }
        public DateTime Order_datetime { get; set; }
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
    public class Order
    {
        public int ID { get; set; }

        public int Cust_ID { get; set; }
        public Customer Customer { get; set; }

        public int P_ID { get; set; }
        public Product Product { get; set; }

        [Range(0,100000.00)]
        public decimal Amount { get; set; }
        public DateTime Order_datetime { get; set; }
    }
}
>>>>>>> ab94dfade7893148820be04f470ce8f209c59092
