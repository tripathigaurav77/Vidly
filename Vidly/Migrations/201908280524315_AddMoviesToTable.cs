namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoviesToTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ( 'Hangover', 5, 28-08-2019, 01-01-2001, 5)");
            Sql("INSERT INTO Movies ( Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ( 'Die Hard', 5, 28-08-2019, 01-01-2001, 1)");
            Sql("INSERT INTO Movies ( Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ( 'The Terminator', 5, 28-08-2019, 01-01-2001, 1)");
            Sql("INSERT INTO Movies ( Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ( 'Toy Story', 5, 28-08-2019, 01-01-2001, 3)");
            Sql("INSERT INTO Movies ( Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ( 'Titanic', 5, 28-08-2019, 01-01-2001, 4)");
        }
        
        public override void Down()
        {
        }
    }
}
