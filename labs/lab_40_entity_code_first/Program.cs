using lab_40_entity_code_first.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace lab_40_entity_code_first
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            List<Category> categories = new List<Category>();

            using(var db = new UserDbContext())  
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                users = db.Users.ToList();
                categories = db.Categories.ToList();

                users.ForEach(user => Console.WriteLine($"User {user.UserId} {user.Username} has date of birth {user.DateOfBirth} with category {user.Category.CategoryName}"));
                categories.ForEach(categories => Console.WriteLine($"Category {categories.CategoryId,-10}{categories.CategoryName}"));



               // var user = new User()
               // {
               //     UserId = 1,
               //     Username = "Some User"
                    
               
               // };

               //// db.Users.Add(user);
               // db.SaveChanges();

            }
        }
    }
}
