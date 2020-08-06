using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.CompilerServices;

namespace EF_Northwind_App
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new NorthwindContext())
            {

                /// ---- 1.1
                var customerQuery = 
                      from customer in db.Customers
                      where customer.City == "Paris" || customer.City =="London"
                      select customer;

                  foreach (var customer in customerQuery)
                  {
                      Console.WriteLine($"{customer.CustomerId} is in {customer.City}");
                  }


                ///----- 1.2 & 1.3
                var bottleQuery =
                      from products in db.Products
                      where products.QuantityPerUnit.Contains("bottle")
                      join supplier in db.Suppliers on products.SupplierId equals supplier.SupplierId
                      select new { productName = products.ProductName, quantity = products.QuantityPerUnit, sName = supplier.CompanyName , country = supplier.Country};

                  foreach (var product in bottleQuery)
                  {
                      Console.WriteLine($"{product.productName} {product.quantity} supplier name {product.sName} country {product.country}");
                  }
                  


                ///------ 1.4
                var categoryNums =
                   db.Products.Include(p => p.Category)
                   .GroupBy(p => p.Category.CategoryName)
                   .OrderBy(item => item.Key)
                   .Select(item => Tuple.Create(item.Key, item.Count()));



                foreach (var result in categoryNums)
                {
                    Console.WriteLine($"{result.Item1} : {result.Item2}");
                }


                ///------- 1.5
                var ukEmployees =
                db.Employees.Where(c => c.Country == "uk");

                foreach (var person in ukEmployees)
                {
                    Console.WriteLine($"{person.TitleOfCourtesy} {person.FirstName} {person.LastName} lives in {person.City}");
                }

            }
        }
    }
}