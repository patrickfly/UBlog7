namespace UBlog.MVC.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, name) VALUES (1, 'Jazz')");
            Sql("INSERT INTO Genres (Id, name) VALUES (2, 'Blues')");
            Sql("INSERT INTO Genres (Id, name) VALUES (3, 'Rock')");
            Sql("INSERT INTO Genres (Id, name) VALUES (4, 'Country')");




        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id IN (1, 2, 3, 4)");
        }
    }
}
