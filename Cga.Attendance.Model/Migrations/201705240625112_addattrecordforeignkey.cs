namespace Cga.Attendance.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addattrecordforeignkey : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.ApplyRecords", "JobNum", c => c.String(maxLength: 50));
            AlterColumn("dbo.Users", "JobNum", c => c.String(nullable: false, maxLength: 50));
            AddPrimaryKey("dbo.Users", "JobNum");
            CreateIndex("dbo.ApplyRecords", "JobNum");
            AddForeignKey("dbo.ApplyRecords", "JobNum", "dbo.Users", "JobNum");
            DropColumn("dbo.Users", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.ApplyRecords", "JobNum", "dbo.Users");
            DropIndex("dbo.ApplyRecords", new[] { "JobNum" });
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Users", "JobNum", c => c.String(maxLength: 50));
            AlterColumn("dbo.ApplyRecords", "JobNum", c => c.String());
            AddPrimaryKey("dbo.Users", "Id");
        }
    }
}
