namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateGenreToMovies : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET GenreId = 5 WHERE Id = 1");
            Sql("UPDATE Movies SET GenreId = 1 WHERE Id = 2");
            Sql("UPDATE Movies SET GenreId = 1 WHERE Id = 3");
            Sql("UPDATE Movies SET GenreId = 3 WHERE Id = 4");
            Sql("UPDATE Movies SET GenreId = 4 WHERE Id = 5");
        }
        
        public override void Down()
        {
        }
    }
}
