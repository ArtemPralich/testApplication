﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ModelsDto
{
    public class ReturnProductBasketDto
    {
        public ReturnProductDto returnProduct { get; set; }
        public int Count { get; set; } = 1;
    }
}
