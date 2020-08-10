using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc;
using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.Text;


namespace lab_40_entity_code_first.Models
{
    class UserDbContext :DbContext
    {
        public DbSet<User> Users { get; set;}
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            // builder.UseSqlite("DataSource=UserDatabase.db");
            builder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=UserDatabase");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Admin" }); 
            builder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Database" }); 
            builder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Standard" });
            
            builder.Entity<User>().HasData(new User { UserId = 1, Username = "some user", DateOfBirth =  new DateTime(1995,10,27),CategoryId=1});
            builder.Entity<User>().HasData(new User { UserId = 2, Username = "some other user", DateOfBirth =  new DateTime(1945,07,16),CategoryId = 2 });
            builder.Entity<User>().HasData(new User { UserId = 3, Username = "some great user", DateOfBirth =  new DateTime(1964,04,05),CategoryId=3});
            
        }
        
    }
}
    