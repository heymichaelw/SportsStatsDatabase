namespace SportsStatsDatabase.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SportsStatsDatabase.SportsStatsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SportsStatsDatabase.SportsStatsContext context)
        {

            {
                Team cornhuskers = new Team
                {
                    TeamId = 1,
                    City = "Lincoln, Nebraska",
                    Founding = DateTime.Now,
                    Wins = 854
                };

                Team buckeyes = new Team
                {
                    TeamId = 2,
                    City = "Columbus, Ohio",
                    Founding = DateTime.Now,
                    Wins = 778
                };

                Team badgers = new Team
                {
                    TeamId = 3,
                    City = "Madison, Wisconsin",
                    Founding = DateTime.Now,
                    Wins = 679
                };

                Team sooners = new Team
                {
                    TeamId = 4,
                    City = "Norman, Oklahoma"
                }
            }
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
