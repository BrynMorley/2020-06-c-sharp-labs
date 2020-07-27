using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace CSharpSQLApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindContext())
            {
                Console.WriteLine(db.ContextId);

                // iterate over and output all customers
                foreach (var c in db.Customers)
                {
                    Console.WriteLine($"Customer {c.GetFullName()} has ID {c.CustomerId} and lives in {c.City}");
                }

                var newCustomer = new Customer()
                {
                    CustomerId = "BLOG",

                    ContactName = "Joe Bloggs",
                    CompanyName = "ToysRUs"
                };

                db.Customers.Add(newCustomer);

                db.SaveChanges();

                // obtain your selected customer
                var selectedCustomer = db.Customers.Where(c => c.CustomerId == "BLOG").FirstOrDefault();
                // now update
                selectedCustomer.City = "Paris";
                // save back to database
                db.SaveChanges();
                // select customer
                selectedCustomer = db.Customers.Where(c => c.CustomerId == "BLOG").FirstOrDefault();

                // remove customer from local DbContext copy of database
                db.Customers.Remove(selectedCustomer);

                // update database
                db.SaveChanges();
            }

        }
    }
}
