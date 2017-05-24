namespace Cga.Attendance.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateWeekReportFlagDefaultValue_3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.WeekReportFlags", "WeekStart", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WeekReportFlags", "WeekStart", c => c.DateTime(nullable: false));
        }
    }
}
