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

                Team cornhuskers = new Team
                {
                    TeamId = 1,
                    City = "Lincoln, Nebraska",
                    Founding = new DateTime(1890, 1, 5),
                    Wins = 854
                };

                Team buckeyes = new Team
                {
                    TeamId = 2,
                    City = "Columbus, Ohio",
                    Founding = new DateTime(1890, 3, 18),
                    Wins = 778
                };

                Team badgers = new Team
                {
                    TeamId = 3,
                    City = "Madison, Wisconsin",
                    Founding = new DateTime(1889, 2, 10),
                    Wins = 679
                };

                Team sooners = new Team
                {
                    TeamId = 4,
                    City = "Norman, Oklahoma",
                    Founding = new DateTime(1895, 4, 20),
                    Wins = 872
                };

            context.Teams.Add(cornhuskers);
            context.Teams.Add(buckeyes);
            context.Teams.Add(badgers);
         
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
