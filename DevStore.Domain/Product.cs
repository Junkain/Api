﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevStore.Domain;

namespace DevStore.Domain
{
    public class Product
    {
        //Primeiro comentário

        public Product()
        {
            this.AcquireDate = DateTime.Now;
        }

        public int Id { get; set; }
        public string  Title { get; set; }
        public decimal Price { get; set; }
        public DateTime AcquireDate { get; set; }
        public bool IsActive { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public override string ToString()
        {
            return this.Title;
        }
    }
}