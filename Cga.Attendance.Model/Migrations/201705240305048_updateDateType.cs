namespace Cga.Attendance.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDateType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.WeekReportFlags", "WeekEnd", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.WeekReports", "FinishDate", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WeekReports", "FinishDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.WeekReportFlags", "WeekEnd", c => c.DateTime(nullable: false));
        }
    }
}
