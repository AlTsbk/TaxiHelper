namespace courseProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Trips",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FromWhere = c.String(),
                        Destination = c.String(),
                        Name = c.String(),
                        PhoneNumber = c.String(),
                        CarName = c.String(),
                        Price = c.String(),
                        Date = c.String(),
                        Time = c.String(),
                        State = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Trips");
        }
    }
}
