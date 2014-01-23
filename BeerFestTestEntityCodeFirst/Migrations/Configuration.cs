namespace BeerFestTestEntityCodeFirst.Migrations
{
    using BeerFestTestEntityCodeFirst.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BeerFestTestEntityCodeFirst.Models.BeerFesDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BeerFestTestEntityCodeFirst.Models.BeerFesDB context)
        {
            context.Events.AddOrUpdate(e => e.Name,
                new Event { Name="Grande Biere 2014" }
                );
        }
    }
}
