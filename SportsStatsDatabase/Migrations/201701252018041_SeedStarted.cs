namespace SportsStatsDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedStarted : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        PlayerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Stat_StatId = c.Int(),
                        Team_TeamId = c.Int(),
                    })
                .PrimaryKey(t => t.PlayerId)
                .ForeignKey("dbo.Stats", t => t.Stat_StatId)
                .ForeignKey("dbo.Teams", t => t.Team_TeamId)
                .Index(t => t.Stat_StatId)
                .Index(t => t.Team_TeamId);
            
            CreateTable(
                "dbo.Stats",
                c => new
                    {
                        StatId = c.Int(nullable: false, identity: true),
                        RushAttempts = c.Int(nullable: false),
                        RushYards = c.Int(nullable: false),
                        RushTouchdowns = c.Int(nullable: false),
                        Receptions = c.Int(nullable: false),
                        ReceivingYards = c.Int(nullable: false),
                        ReceivingTouchdowns = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StatId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        TeamId = c.Int(nullable: false, identity: true),
                        City = c.String(),
                        Founding = c.DateTime(nullable: false),
                        Wins = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TeamId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "Team_TeamId", "dbo.Teams");
            DropForeignKey("dbo.Players", "Stat_StatId", "dbo.Stats");
            DropIndex("dbo.Players", new[] { "Team_TeamId" });
            DropIndex("dbo.Players", new[] { "Stat_StatId" });
            DropTable("dbo.Teams");
            DropTable("dbo.Stats");
            DropTable("dbo.Players");
        }
    }
}
