﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreMVCOefeningenreeks2.Entities
{
    public partial class ShopItem
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        public string Name { get; set; }
        public byte? Quantity { get; set; }
        public int? CategoryId { get; set; }
        public int? CartId { get; set; }

        public Cart Cart { get; set; }
        public Category Category { get; set; }
    }
}
