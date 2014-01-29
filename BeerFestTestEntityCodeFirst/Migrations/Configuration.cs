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
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(BeerFestTestEntityCodeFirst.Models.BeerFesDB context)
        {
            context.Events.AddOrUpdate(e => e.Name,
                new Event { Name = "Grande Biere 2014", StartDate = DateTime.Parse("2014-4-25"), EndDate = DateTime.Parse("2014-4-27"), TicketPrice = 5000, ComingSoon = false },
                new Event { Name = "BeerFes Tokyo 2014", StartDate = DateTime.Parse("2014-5-31"), EndDate = DateTime.Parse("2014-6-1"), TicketPrice = 5000, ComingSoon = false }
                );
        }
    }
}
