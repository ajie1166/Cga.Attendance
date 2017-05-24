namespace Cga.Attendance.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateWeekReportFlagDefaultValue : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.WeekReportFlags", "Flag", c => c.Int());
            AlterColumn("dbo.WeekReportFlags", "WeekStart", c => c.DateTime(nullable: false));
            AlterColumn("dbo.WeekReportFlags", "WeekEnd", c => c.DateTime(nullable: false));
            AlterColumn("dbo.WeekReports", "FinishDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WeekReports", "FinishDate", c => c.String());
            AlterColumn("dbo.WeekReportFlags", "WeekEnd", c => c.String());
            AlterColumn("dbo.WeekReportFlags", "WeekStart", c => c.String());
            AlterColumn("dbo.WeekReportFlags", "Flag", c => c.Int(nullable: false));
        }
    }
}
