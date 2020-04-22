namespace HospitalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Time = c.String(),
                        Doctor = c.String(),
                        Patient = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Emergencies",
                c => new
                    {
                        EmergencyId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Title = c.String(),
                        Article = c.String(),
                        KeywordOne = c.String(),
                        KeywordTwo = c.String(),
                        KeywordThree = c.String(),
                    })
                .PrimaryKey(t => t.EmergencyId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Emergencies");
            DropTable("dbo.Appointments");
        }
    }
}
