using eticaret.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eticaret.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; } //Add categories table on database

        public DbSet<Product> Products { get; set; } //product modelini oluşturduktan sonra db ye kaydetmek için yazıyoruz sonra console dan migration ekliyoruz add-migration AddProduct
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
