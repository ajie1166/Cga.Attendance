namespace Cga.Attendance.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApproveChains",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(),
                        SupervisorjobNum = c.Int(nullable: false),
                        ParentId = c.Int(nullable: false),
                        Description = c.String(),
                        CreateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OriginalRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobNum = c.String(),
                        CheckTime = c.DateTime(),
                        CreateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VacationLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobNum = c.String(),
                        Description = c.String(),
                        OperaDateTime = c.DateTime(),
                        Type = c.Int(nullable: false),
                        Hours = c.Int(nullable: false),
                        Remark = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vacations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobNum = c.String(),
                        VacationId = c.Int(nullable: false),
                        Expirdate = c.DateTime(nullable: false, storeType: "date"),
                        Hours = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vacations");
            DropTable("dbo.VacationLogs");
            DropTable("dbo.OriginalRecords");
            DropTable("dbo.Departments");
            DropTable("dbo.ApproveChains");
        }
    }
}
