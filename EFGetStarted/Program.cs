using System;
using System.Linq;

namespace EFGetStarted
{
    class Program
    {
        static void Main()
        {
            using (var db = new BloggingContext())
            {
                // Create
                Console.WriteLine("Inserting a new blog");
                db.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
               
                Console.WriteLine("Inserting a new blog");
                db.Add(new Blog { Url = "https://docs.microsoft.com/en-us/archive/blogs/adonet/ef7-rc1-ef-moving-to-the-net-blog" });
              
                Console.WriteLine("Inserting a new blog");
                db.Add(new Blog { Url = "https://docs.microsoft.com/en-us/archive/blogs/adonet/ef7-beta-8-available" });
                db.SaveChanges();


                // Read
                Console.WriteLine("Querying for a blog");
                var blog = db.Blogs
                    .OrderBy(b => b.BlogId)
                    .First();

                // Update
                Console.WriteLine("Updating the blog and adding a post");
                blog.Url = "https://devblogs.microsoft.com/dotnet";
                blog.Posts.Add(
                    new Post
                    {
                        Title = "Hello World",
                        Content = "I wrote an app using EF Core!"
                    });
                var blog2 = db.Blogs
                    .OrderBy(b => b.BlogId)
                    .Where(b => b.BlogId == 2).FirstOrDefault();

                blog2.Posts.Add(
                   new Post
                   {
                       Title = "E",
                       Content = "E"
                   });
                blog.Posts.Add(
                   new Post
                   {
                       Title = "boo!",
                       Content = "Spooked ya!"
                   });
                db.SaveChanges();


                // Delete
                Console.WriteLine("Delete the blog");
                db.Remove(blog);
                db.SaveChanges();
            }
        }
    }
}