﻿namespace Factory.DAL.Entities
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ProductType { get; set; }
    }
}