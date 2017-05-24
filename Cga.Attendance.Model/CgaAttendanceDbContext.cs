namespace Cga.Attendance.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CgaAttendanceDbContext : DbContext
    {
        //您的上下文已配置为从您的应用程序的配置文件(App.config 或 Web.config)
        //使用“CgaAttendanceDbContext”连接字符串。默认情况下，此连接字符串针对您的 LocalDb 实例上的
        //“Cga.Attendance.Model.CgaAttendanceDbContext”数据库。
        // 
        //如果您想要针对其他数据库和/或数据库提供程序，请在应用程序配置文件中修改“CgaAttendanceDbContext”
        //连接字符串。
        public CgaAttendanceDbContext()
            : base("name=CgaAttendanceDbContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<WeekReportFlag>().Property(m => m.WeekStart).IsRequired();
        }

        //为您要在模型中包含的每种实体类型都添加 DbSet。有关配置和使用 Code First  模型
        //的详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=390109。

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        /// <summary>
        /// 用户表
        /// </summary>
        public DbSet<User> Users { get; set; }
        /// <summary>
        /// 导航信息表
        /// </summary>
        public DbSet<Item> Items { get; set; }
        /// <summary>
        /// 用户拥有的导航权限
        /// </summary>
        public DbSet<UserItem> UserItems { get; set; }
        /// <summary>
        /// 用户操作日志
        /// </summary>
        public DbSet<UserOperationLog> UserOperationLogs { get; set; }
        /// <summary>
        /// 周报
        /// </summary>
        public DbSet<WeekReport> WeekReports { get; set; }
        /// <summary>
        /// 周数表(针对周报建表)
        /// </summary>
        public DbSet<WeekReportFlag> WeekReportFlags { get; set; }
        /// <summary>
        /// 假期表
        /// </summary>
        public DbSet<Vacation> Vacations { get; set; }
        /// <summary>
        /// 假期更新日志表
        /// </summary>
        public DbSet<VacationLog> VacationLogs { get; set; }
        /// <summary>
        /// 原始数据表
        /// </summary>
        public DbSet<OriginalRecord> OriginalRecords { get; set; }
        /// <summary>
        /// 审批链
        /// </summary>
        public DbSet<ApproveChain> ApproveChains { get; set; }
        /// <summary>
        /// 部门表
        /// </summary>
        public DbSet<Department> Departments { get; set; }
        /// <summary>
        /// 排版表
        /// </summary>
        public DbSet<ArrangeDate> ArrangeDates { get; set; }
        /// <summary>
        /// 员工申请假期表
        /// </summary>
        public DbSet<ApplyRecord> ApplyRecords { get; set; }
        /// <summary>
        /// 考勤表
        /// </summary>
        public DbSet<AttendanceRecord> AttendanceRecords { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}