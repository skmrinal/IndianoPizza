﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndianoPizza.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int PizzaId { get; set; }
        public int Amount { get; set; }
        [Precision(18, 2)]
        public decimal Price { get; set; }
        public virtual Pizzas Pizza { get; set; }
        public virtual Order Order { get; set; }
    }
}
