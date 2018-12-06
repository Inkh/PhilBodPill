using Microsoft.EntityFrameworkCore;
using PhilBodPill.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhilBodPill.Data
{
    public class PhilBodPillDbContext : DbContext
    {
        public PhilBodPillDbContext(DbContextOptions<PhilBodPillDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ID = 1,
                    Name = "Bertrand Russell Pillow",
                    Image = "/Pillows/BertrandRussell.png",
                    Price = 15,
                    Description = "Have some tea with Bertrand Russell"
                },
                new Product
                {
                    ID = 2,
                    Name = "Friedrich Nietzche",
                    Image = "/Pillows/FriedrichNietzche.png",
                    Price = 15,
                    Description = "Have some fun with Friedrich Nietzche"
                },
                new Product
                {
                    ID = 3,
                    Name = "Immanuel Kant",
                    Image = "/Pillows/ImmanuelKant.png",
                    Price = 15,
                    Description = "Sleep with Immanuel Kant"
                },
                new Product
                {
                    ID = 4,
                    Name = "Karl Marx",
                    Image = "/Pillows/KarlMarx.png",
                    Price = 15,
                    Description = "Whoa"
                },
                new Product
                {
                    ID = 5,
                    Name = "Ludwig Wittgenstein",
                    Image = "/Pillows/LudwigWittgenstein.png",
                    Price = 15,
                    Description = "Chill with Ludwig for a while"
                },
                new Product
                {
                    ID = 6,
                    Name = "Miyamoto Musashi",
                    Image = "/Pillows/MiyamotoMusashi.png",
                    Price = 15,
                    Description = "It's Musashi!"
                },
                new Product
                {
                    ID = 7,
                    Name = "Plato",
                    Image = "/Pillows/Plato.png",
                    Price = 15,
                    Description = "It's Plato! What else can we say?"
                },
                new Product
                {
                    ID = 8,
                    Name = "Rene Descartes",
                    Image = "/Pillows/ReneDescartes.png",
                    Price = 15,
                    Description = "Sleep well with Rene"
                },
                new Product
                {
                    ID = 9,
                    Name = "Soren Kierkegaard",
                    Image = "/Pillows/SorenKierkegaard.png",
                    Price = 15,
                    Description = "Never have insomnia"
                },
                new Product
                {
                    ID = 10,
                    Name = "Thomas Aquinas",
                    Image = "/Pillows/ThomasAquinas.png",
                    Price = 15,
                    Description = "Keep your nights cozy and warm"
                }
            );

        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Basket> Basket { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
