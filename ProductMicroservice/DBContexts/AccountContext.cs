using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductMicroservice.Models;

namespace ProductMicroservice.DBContexts
{
    public class AccountContext : DbContext
    {
        public AccountContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }
        public DbSet<Account> Accounts { get; set; }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Account
                {
                    Id = 1,
                    FirstName = "admin",
                    LastName = "",
                    AccountType = "admin",
                    Email="admin@site.com",
                    password ="user123",
                }
            );
        }
    }
}