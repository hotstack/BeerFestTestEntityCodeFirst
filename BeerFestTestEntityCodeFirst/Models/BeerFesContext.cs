using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BeerFestTestEntityCodeFirst.Models
{
    public class BeerFesDB : DbContext
    {
        public BeerFesDB() : base("name=DefaultConnection") { }
        public DbSet<Event> Events { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<BeerCategory> BeerCategories { get; set; }
        public DbSet<BeerStyle> BeerStyles { get; set; }
        public DbSet<Hours> EventHours { get; set; } //this is a crappy name.. maybe change the class name?
        public DbSet<Image> Images { get; set; }
        public DbSet<SpecialEvent> SpecialEvents { get; set; }
        public DbSet<Beer> Beers { get; set; }
        public DbSet<BeerEvent> BeerEvents { get; set; }
        public DbSet<CompanyEvent> CompanyEvents { get; set; }
    }
}