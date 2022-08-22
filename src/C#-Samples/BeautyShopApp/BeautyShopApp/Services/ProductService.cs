using BeautyShopApp.Models;
using System.Collections.Generic;

namespace BeautyShopApp.Services
{
    public class ProductService
    {
        static ProductService _instance;

        public static ProductService Instance
        {
            get { return _instance ?? (_instance = new ProductService()); }
        }

        public List<Product> GetProducts()
        {
            return new List<Product> {
              new Product {   
                  Name = "Moisturiser",         
                  Image = "moisturiser_01.png", 
                  Description = "Oil balancing mask",  
                  Price = 11.99,
              },
              new Product {          
                  Name = "Facial Cleanser",
                  Image = "facial_cleanser_01.png",
                  Description = "Citrus refreshes senses",
                  Price = 9.99,
              },
              new Product {          
                  Name = "Cleansing Oil",   
                  Image = "cleansing_oil_01.png",
                  Description = "Super greens",
                  Price = 12.99,
              },
              new Product {                
                  Name = "Micellar Cleansing",
                  Image = "micellar_01.png", 
                  Description = "Signature water",
                  Price = 10.99,
              },
              new Product {    
                  Name = "Shampoo",      
                  Image = "shampoo_01.png",  
                  Description = "Citrus refreshes senses",
                  Price = 8.99,
              },
           };
        }
    }
}
