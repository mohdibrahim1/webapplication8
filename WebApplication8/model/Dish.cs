﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8.model
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int HalfPrice { get; set; }
        public int FullPrice { get; set; }
        public int Qty { get; set; }
        public int MainCategoryId { get; set; }
        public string MainCategoryName { get; set; }
        public bool IsVeg { get; set; }
        public bool IsHalf { get; set; }
        public bool IsFull { get; set; }
    }
}
