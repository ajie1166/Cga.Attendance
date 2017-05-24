namespace Cga.Attendance.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class finishtablesdesign : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApplyRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobNum = c.String(),
                        CompanyId = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                        SupervisorJobNum = c.Int(nullable: false),
                        VacationType = c.Int(nullable: false),
                        Title = c.String(),
                        Reason = c.String(),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        AttachUrl = c.String(),
                        Hours = c.Int(nullable: false),
                        ApprovingJobNum = c.String(),
                        ApprovedJobNums = c.String(),
                        NeedApproveJobNum = c.String(),
                        Members = c.String(),
                        Status = c.Int(nullable: false),
                        CreateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ArrangeDates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ArrangedDate = c.DateTime(nullable: false),
                        Type = c.Int(nullable: false),
                        CreateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AttendanceRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobNum = c.String(),
                        InitWorkStartTime = c.DateTime(nullable: false),
                        InitWorkEndTime = c.DateTime(nullable: false),
                        ActualStartTime = c.DateTime(nullable: false),
                        ActualEndTime = c.DateTime(nullable: false),
                        SchedulingType = c.Int(nullable: false),
                        AttendaceDate = c.DateTime(nullable: false),
                        AttandanceType = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        ExceptionOne = c.Int(nullable: false),
                        ExceptionTwo = c.Int(nullable: false),
                        WorkDays = c.Double(nullable: false),
                        OperateJobNum = c.String(),
                        CreateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AttendanceRecords");
            DropTable("dbo.ArrangeDates");
            DropTable("dbo.ApplyRecords");
        }
    }
}
