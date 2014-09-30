namespace SocialDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReadBool : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "Read", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "Read");
        }
    }
}
