namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateForSomeCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Dob = 15-05-1994 WHERE Id = 1");
            Sql("UPDATE Customers SET Dob = 16-10-1994 WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
