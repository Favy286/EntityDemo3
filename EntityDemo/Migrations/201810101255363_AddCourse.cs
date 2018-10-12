namespace EntityDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCourse : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Courses (course_name,semester) VALUES ('ADSE',4)");
            Sql("INSERT INTO Courses (course_name,semester) VALUES ('ACNS',4)");
            Sql("INSERT INTO Courses (course_name,semester) VALUES ('DCISM',2)");
            Sql("INSERT INTO Courses (course_name,semester) VALUES ('CPISM',1)");
            Sql("INSERT INTO Courses (course_name,semester) VALUES ('IT',1)");

        }

        public override void Down()
        {
        }
    }
}
