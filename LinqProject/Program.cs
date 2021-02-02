using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            { new Product{ProductId = 1, CategoryId=1, ProductName="Bilgisayar", UnitsInStock=3},
              new Product{ProductId = 2, CategoryId=1,  ProductName="Telefon", UnitsInStock=2},
              new Product{ProductId = 3, CategoryId=2,  ProductName="Ütü", UnitsInStock=2}
            };
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1,CategoryName="İletişim"},
                new Category{CategoryId=2,CategoryName="Ev Aletleri"}
            };

            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName);
            }

            var result = products.Where(product => product.UnitsInStock>1);

            GetProducts(products);
        }

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>(); //liste aç 

            foreach (var product in products) //bütün ürünleri gez
            {
                if(product.UnitsInStock>1) //stokta olanları
                {
                    filteredProducts.Add(product); //listeye ekle
                }
            }
            return filteredProducts; //listeyi döndür
        }

        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(product => product.UnitsInStock > 1).ToList(); //where  GetProducts'ın yaptığı işi tek satırda yapar
        }
    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public int UnitsInStock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
