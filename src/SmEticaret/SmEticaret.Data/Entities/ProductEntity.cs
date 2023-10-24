﻿namespace SmEticaret.Data.Entities
{
    public class ProductEntity : EntityBase
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public string ImageUrl { get; set; }
        public int SellerId { get; set; }
    }
}
