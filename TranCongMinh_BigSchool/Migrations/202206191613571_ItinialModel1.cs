namespace TranCongMinh_BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ItinialModel1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "Lecturer_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Courses", new[] { "Lecturer_Id" });
            RenameColumn(table: "dbo.Courses", name: "Lecturer_Id", newName: "LecturerId");
            AddColumn("dbo.Courses", "IsCanceled", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Courses", "LecturerId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Courses", "LecturerId");
            AddForeignKey("dbo.Courses", "LecturerId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "LecturerId", "dbo.AspNetUsers");
            DropIndex("dbo.Courses", new[] { "LecturerId" });
            AlterColumn("dbo.Courses", "LecturerId", c => c.String(maxLength: 128));
            DropColumn("dbo.Courses", "IsCanceled");
            RenameColumn(table: "dbo.Courses", name: "LecturerId", newName: "Lecturer_Id");
            CreateIndex("dbo.Courses", "Lecturer_Id");
            AddForeignKey("dbo.Courses", "Lecturer_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
