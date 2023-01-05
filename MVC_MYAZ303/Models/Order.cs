﻿using System;
using System.Collections.Generic;

namespace MVC_MYAZ303.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public DateTime Date { get; set; }
        public ICollection<Product> Products { get; set; }
        public int Quantities { get; set; }
    }
}
