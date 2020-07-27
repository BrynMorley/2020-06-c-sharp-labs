using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EFGetStarted;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace BusinessLayer
{
    public class BlogManager
    {
        public void CreateBlog(string blogUrl)
        {
            using (var db = new BloggingContext())
            {
                db.Add(new Blog { Url = blogUrl });
                db.SaveChanges();
            }
        }

        public void AddPost(string blogUrl, string postTitle, string postContent)
        {
            using (var db = new BloggingContext()) 
            {
                var blog = db.Blogs
                      .Where(b => b.Url == blogUrl)
                      .First();

                blog.Posts.Add(
                       new Post
                       {
                           Title = postTitle,
                           Content = postContent
                       });
                db.SaveChanges();
            }
        }

        public void Display()
        {
            using (var db = new BloggingContext())
            {

            }
        }

        public void DeleteBlog(string blogUrl)
        {
            using (var db = new BloggingContext())
            {
                var blog = db.Blogs
                  .Where(b => b.Url == blogUrl)
                  .First();

                // Delete
               
                db.Remove(blog);
                db.SaveChanges();
            }
        }

        public void DeletePost(string blogUrl, string postTitle)
        {
            using (var db = new BloggingContext())
            {
                var blog = db.Blogs
                  .Where(b => b.Url == blogUrl)
                  .First();
                var ID = blog.BlogId;
                
                var post = db.Posts
                    .Where(p => p.Title == postTitle &&p.BlogId == ID)
                    .First();

                // Delete
                
                db.Remove(post);
                db.SaveChanges();
            }
        }
    }
}
