namespace Cga.Attendance.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addattrecordforeignkey_1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AttendanceRecords", "JobNum", c => c.String(maxLength: 50));
            AlterColumn("dbo.Departments", "SupervisorjobNum", c => c.String(maxLength: 50));
            AlterColumn("dbo.UserOperationLogs", "JobNum", c => c.String(maxLength: 50));
            AlterColumn("dbo.VacationLogs", "JobNum", c => c.String(maxLength: 50));
            AlterColumn("dbo.Vacations", "JobNum", c => c.String(maxLength: 50));
            AlterColumn("dbo.WeekReports", "JobNum", c => c.String(maxLength: 50));
            CreateIndex("dbo.AttendanceRecords", "JobNum");
            CreateIndex("dbo.Departments", "SupervisorjobNum");
            CreateIndex("dbo.UserItems", "JobNum");
            CreateIndex("dbo.UserOperationLogs", "JobNum");
            CreateIndex("dbo.VacationLogs", "JobNum");
            CreateIndex("dbo.Vacations", "JobNum");
            CreateIndex("dbo.WeekReports", "JobNum");
            AddForeignKey("dbo.AttendanceRecords", "JobNum", "dbo.Users", "JobNum");
            AddForeignKey("dbo.Departments", "SupervisorjobNum", "dbo.Users", "JobNum");
            AddForeignKey("dbo.UserItems", "JobNum", "dbo.Users", "JobNum");
            AddForeignKey("dbo.UserOperationLogs", "JobNum", "dbo.Users", "JobNum");
            AddForeignKey("dbo.VacationLogs", "JobNum", "dbo.Users", "JobNum");
            AddForeignKey("dbo.Vacations", "JobNum", "dbo.Users", "JobNum");
            AddForeignKey("dbo.WeekReports", "JobNum", "dbo.Users", "JobNum");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WeekReports", "JobNum", "dbo.Users");
            DropForeignKey("dbo.Vacations", "JobNum", "dbo.Users");
            DropForeignKey("dbo.VacationLogs", "JobNum", "dbo.Users");
            DropForeignKey("dbo.UserOperationLogs", "JobNum", "dbo.Users");
            DropForeignKey("dbo.UserItems", "JobNum", "dbo.Users");
            DropForeignKey("dbo.Departments", "SupervisorjobNum", "dbo.Users");
            DropForeignKey("dbo.AttendanceRecords", "JobNum", "dbo.Users");
            DropIndex("dbo.WeekReports", new[] { "JobNum" });
            DropIndex("dbo.Vacations", new[] { "JobNum" });
            DropIndex("dbo.VacationLogs", new[] { "JobNum" });
            DropIndex("dbo.UserOperationLogs", new[] { "JobNum" });
            DropIndex("dbo.UserItems", new[] { "JobNum" });
            DropIndex("dbo.Departments", new[] { "SupervisorjobNum" });
            DropIndex("dbo.AttendanceRecords", new[] { "JobNum" });
            AlterColumn("dbo.WeekReports", "JobNum", c => c.String());
            AlterColumn("dbo.Vacations", "JobNum", c => c.String());
            AlterColumn("dbo.VacationLogs", "JobNum", c => c.String());
            AlterColumn("dbo.UserOperationLogs", "JobNum", c => c.String());
            AlterColumn("dbo.Departments", "SupervisorjobNum", c => c.Int(nullable: false));
            AlterColumn("dbo.AttendanceRecords", "JobNum", c => c.String());
        }
    }
}
