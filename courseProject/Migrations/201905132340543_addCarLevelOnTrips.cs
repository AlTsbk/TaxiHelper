namespace courseProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCarLevelOnTrips : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trips", "CarLevel", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Trips", "CarLevel");
        }
    }
}
