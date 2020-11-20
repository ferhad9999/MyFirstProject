﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Infrastructure.Models
{
    public  class Sale
    {
        public int Number  { get; set; }
        public double Amount { get; set; }
        public List<SaleItem> SaleItems { get; set; }
        public DateTime Date { get; set; }

    }
}
