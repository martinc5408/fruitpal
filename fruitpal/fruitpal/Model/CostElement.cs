﻿using System;
using System.Collections.Generic;
using System.Text;

namespace fruitpal.Model
{
    public class CostElement
    {
        public int Price { get; set; }
        public int Quantity { get; set; }
        public double FixedOverhead { get; set; }
        public double VariableOverhead { get; set; }
    }
}