namespace Cga.Attendance.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWeekReportAndWeekReportFlag : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemName = c.String(maxLength: 50),
                        ParentId = c.Int(),
                        ItemUrl = c.String(maxLength: 255),
                        IconUrl = c.String(maxLength: 255),
                        CreateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobNum = c.String(maxLength: 50),
                        ItemId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserOperationLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobNum = c.String(),
                        Name = c.String(),
                        LogDescriptions = c.String(),
                        CreateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobNum = c.String(maxLength: 50),
                        NickName = c.String(maxLength: 50),
                        PassWord = c.String(maxLength: 200),
                        Name = c.String(maxLength: 50),
                        Mobile = c.String(maxLength: 50),
                        JoinDate = c.DateTime(storeType: "date"),
                        SupervisorId = c.Int(),
                        DepartmentId = c.Int(),
                        RoleId = c.Int(),
                        IsApprove = c.Int(),
                        IsCeo = c.Int(),
                        State = c.Int(),
                        Email = c.String(maxLength: 100),
                        Remark = c.String(unicode: false, storeType: "text"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.UserOperationLogs");
            DropTable("dbo.UserItems");
            DropTable("dbo.Items");
        }
    }
}
