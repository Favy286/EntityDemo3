namespace EntityDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class facultyModuleClass : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Modules(module_name,semester) VALUES ('C-SHARP',2) ");
            Sql("INSERT INTO Modules(module_name,semester) VALUES ('HTML',1) ");
            Sql("INSERT INTO Modules(module_name,semester) VALUES ('UWP',3) ");
            Sql("INSERT INTO Modules(module_name,semester) VALUES ('PHP',4) ");
            Sql("INSERT INTO Modules(module_name,semester) VALUES ('Googe Adwords',2) ");
        }
        
        public override void Down()
        {
        }
    }
}
