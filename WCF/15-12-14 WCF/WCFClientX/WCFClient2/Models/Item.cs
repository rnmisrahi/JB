﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFClient2.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}