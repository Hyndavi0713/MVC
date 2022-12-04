using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _HOL2.Models
{
    public class Product
    {
        public int productId { get; set; }
        public string Productname { get; set; }
        public double Price { get; set; }
        public IEnumerable<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product{productId=1,Productname="Product1",Price=900},
            new Product { productId = 2, Productname = "Product2", Price = 700 },
            new Product { productId = 3, Productname = "Product3", Price = 650 },
            new Product { productId = 4, Productname = "Product4", Price = 950 },
            new Product { productId = 5, Productname = "Product5", Price = 800 },

        };
        }
    }
}

        
    
