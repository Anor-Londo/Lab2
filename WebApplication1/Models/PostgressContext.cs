using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.DTO;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace WebApplication1.Models
{
    public class PostgressContext: DbContext
    {

        public DbSet<Categories> Categories { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Postss> Posts { get; set; }
        public DbSet<Ratings> Ratings { get; set; }
        public DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;Port=3306;User Id=root; Password=1234;Database=mybd;");
            optionsBuilder.UseMySQL("Server=localhost;Port=3306;User Id=root; Password=1234;Database=comments;");
            optionsBuilder.UseMySQL("Server=localhost;Port=3306;User Id=root; Password=1234;Database=user;");
            optionsBuilder.UseMySQL("Server=localhost;Port=3306;User Id=root; Password=1234;Database=rating;");
        }
    }
}
