namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameToMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("MembershipTypes", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("MembershipTypes", "Name");
        }
    }
}
