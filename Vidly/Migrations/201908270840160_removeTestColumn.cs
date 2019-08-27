namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeTestColumn : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE MembershipTypes DROP COLUMN test");           
        }
        
        public override void Down()
        {
        }
    }
}
