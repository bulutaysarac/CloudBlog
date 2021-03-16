using CloudBlog.Lib.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBlog.Lib.DataAccess.Concrete.EntityFramework
{
    public class CloudBlogContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=BULUTAY\SQLEXPRESS;Database=BlogDb;User Id=sa;Password=as123;");
        }

        public DbSet<Admin> Admins  { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleTag> ArticleTags { get; set; }
        public DbSet<Category> Categories  { get; set; }
        public DbSet<Question> Questions  { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
