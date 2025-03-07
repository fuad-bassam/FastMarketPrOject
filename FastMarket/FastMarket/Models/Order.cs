﻿using System;
using System.Collections.Generic;

namespace FastMarket.Models
{
    // Order Model
    public class Order
    {

        public int Id { get; set; }
        public string UserID {  get; set; }
         public decimal TotalPrice {get; set; }
        public int Count { get; set; }
        public string Address { get; set; }
        public DateTime? datetime { get; set; }
        public string OrderListJSON { get; set; }
    }
}
