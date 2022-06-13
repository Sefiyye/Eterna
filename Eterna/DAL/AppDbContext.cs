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
        public DbSet<Client> Clients { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<HomeCard> HomeCards { get; set; }
        public DbSet<LastCard> LastCards { get; set; }
        public DbSet<Rule> Rules { get; set; }
        public DbSet<ClientsImage> ClientsImages{ get; set; }


    }
}

