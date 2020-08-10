using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;    

namespace lab_39_api_code_first.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<MyClass> MyClasses { get; set; }

        public MyDbContext() { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<MyClass>(item =>
            {
                item.Property(myClass => myClass.MyClassId).IsRequired();
            });

            builder.Entity<MyClass>().HasData(new MyClass { MyClassId = 1, FieldName1 = "some data" });
            builder.Entity<MyClass>().HasData(new MyClass { MyClassId = 2, FieldName1 = "some more data" });
            builder.Entity<MyClass>().HasData(new MyClass { MyClassId = 3, FieldName1 = "some even more data" });
        }
    }
}
