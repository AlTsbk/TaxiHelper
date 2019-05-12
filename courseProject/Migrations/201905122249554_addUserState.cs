namespace courseProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUserState : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "state", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "state");
        }
    }
}
