﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lektion13.Domain.Entities.Abstract;

namespace Lektion13.Domain.Entities
{
    public class Product : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}