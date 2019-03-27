namespace NghiaNgo_BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into categories (id, name) values (1,'Development')");
            Sql("Insert into categories (id, name) values (2,'Business')");
            Sql("Insert into categories (id, name) values (3,'Marketing')");
        }
        
        public override void Down()
        {
        }
    }
}
