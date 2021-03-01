using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace Lab5.Models
{
    public class ProductDatabaseInitializer  
        
    {
        public static void Seed(ProductContext context) 
        {
            if (!context.Categories.Any())
            {
                GetCategories().ForEach(c => context.Categories.Add(c)); context.SaveChanges();
            }
            if (!context.Products.Any())
            {
                GetProducts().ForEach(p => context.Products.Add(p)); context.SaveChanges();
            }
        }
        private static List<Category> GetCategories() 
        { 
            var categories = new List<Category> 
            { 
                new Category 
                { 
                    CategoryID = 1, CategoryName = "Процесори" 
                }, 
                new Category 
                { 
                    CategoryID = 2, CategoryName = "Видео карти" 
                }, 
                new Category 
                { 
                    CategoryID = 3, CategoryName = "RAM памет" 
                }, 
            }; 
            return categories; }
        private static List<Product> GetProducts()
        {
            var products = new List<Product>
            { 
                new Product { ProductID = 1, ProductName = "AMD CPU Athlon 200GE", 
                    Description = "(AM4/3.20GHz/4MB)", 
                    ImagePath ="images/img09.jpg", UnitPrice = 115.00, 
                    CategoryID = 1 }, 
                new Product { ProductID = 2, ProductName = "Intel CPU Pentium G5400", 
                    Description = "(1151/3.7 GHz/4 MB)", 
                    ImagePath ="images/img10.jpg", UnitPrice = 120.00, 
                    CategoryID = 1 }, 
                new Product { ProductID = 3, ProductName = "Intel CPU Core i3 9100F", 
                    Description = "(1151/3.6 GHz/6 MB)", 
                    ImagePath ="images/img11.jpg", UnitPrice = 179.00, 
                    CategoryID = 1 }, 
                new Product { ProductID = 4, ProductName = "AMD CPU Ryzen 3 3200G", 
                    Description = "(AM4/3.6 GHz/6 MB)", 
                    ImagePath ="images/img12.jpg", UnitPrice = 199.00, 
                    CategoryID = 1 }, 
                new Product { ProductID = 5, ProductName = "Intel CPU Core i7 7740X", 
                    Description = "(2066/4.30 GHz/8 MB)", 
                    ImagePath ="images/img13.jpg", UnitPrice = 449.00, 
                    CategoryID = 1 }, 
                new Product { ProductID = 6, ProductName = "MSI VGA GeForce GT 710 1GB", 
                    Description = "С памет 1GB и пасивна система за охлаждане", 
                    ImagePath ="images/img14.jpg", UnitPrice = 79.00, 
                    CategoryID = 2 }, 
                new Product { ProductID = 7, ProductName = "Sapphire PCI-E R5 230 2GB",
                    Description = "С GPU 625MHz и памет 2GB DDR5 на 1334MHz", 
                    ImagePath ="images/img15.jpg", UnitPrice = 99.00, 
                    CategoryID = 2 }, 
                new Product { ProductID = 8, ProductName = "Gigabyte VGA GeForce GTX 1650 Windforce 4GB", 
                    Description = "4GB памет GDDR5 за графики с висока рязкост", 
                    ImagePath ="images/img16.jpg", UnitPrice = 375.00, 
                    CategoryID = 2 }, 
                new Product { ProductID = 9, ProductName = "Asrock VGA Radeon RX 570 8GB Phantom Gaming", 
                    Description = "Охлаждане XXL на ASRock и памет 8GB GDDR5", 
                    ImagePath ="images/img17.jpg", UnitPrice = 329.00, 
                    CategoryID = 2 }, 
                new Product { ProductID = 10, ProductName = "Sapphire VGA Radeon RX 590 8GB", 
                    Description = "NITRO+ RX 590 8GB AMD 50 Gold Edition", 
                    ImagePath ="images/img18.jpg", UnitPrice = 549.00, 
                    CategoryID = 2 }, 
                new Product {ProductID=11, ProductName="TeamGroup RAM DDR 1GB Dimm 400MHz", 
                    Description = "Подобри времето за реакция на стария си лаптоп по най-лесния начин", 
                    ImagePath ="images/img19.jpg", UnitPrice = 35.00, 
                    CategoryID = 3 }, 
                new Product { ProductID = 12, ProductName = "GoldKey Desktop RAM Value 4GB 1600MHz DDR3", 
                    Description = "С обем 4GB DDR3, скорост 1600MHz и консумация 1,5V",
                    ImagePath ="images/img20.jpg", UnitPrice = 49.00, 
                    CategoryID = 3 }, 
                new Product { ProductID = 13, ProductName = "GoldKey RAM DDR2 2GB Dimm 800MHz", 
                    Description = "С timings  6-6-6-18, и волтаж 1,80V", 
                    ImagePath ="images/img21.jpg", UnitPrice = 59.00, 
                    CategoryID = 3 }, 
                new Product { ProductID = 14, ProductName = "Corsair Desktop RAM Vengeance 4GB 2400MHz DDR4", 
                    Description = "С честота от 2400MHz и с работно напрежение само 1,2V", 
                    ImagePath ="images/img22.jpg", UnitPrice = 59.00, 
                    CategoryID = 3 }, 
                new Product { ProductID = 15, ProductName = "GoldKey Desktop RAM Value 2GB 1600MHz DDR3", 
                    Description = "RAM памет 2GB на 1600MHz", 
                    ImagePath ="images/img23.jpg", UnitPrice = 69.00, 
                    CategoryID = 3 },
                
            }; 
            return products;
        }
    }
}