namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MembershipTypes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "test", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "test");
        }
    }
}
