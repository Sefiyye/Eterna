using Eterna.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Eterna.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Contact>Contacts { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Statistics> Statistics { get; set; }
        public DbSet<News> News { get; set; }


    }
}

