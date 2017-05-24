using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cga.Attendance.Model
{
    public class WeekReport
    {/// <summary>
    /// 编号 主键
    /// </summary>
        [Key]
        [Description("编号 主键")]
        public int Id { get; set; }
        /// <summary>
        /// 工号
        /// </summary>
        [Description("工号")]
        [ForeignKey("User")]
        public string JobNum { get; set; }

        public User User { get; set; }
        /// <summary>
        /// 模块
        /// </summary>
        [Description("模块")]
        public string WorkModule { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        [Description("内容")]
        public string WorkContent { get; set; }
        /// <summary>
        /// 完成时间
        /// </summary>
        [Description("完成时间")]
        [Column(TypeName = "Date")]
        public DateTime FinishDate { get; set; }
        /// <summary>
        /// 工作进度
        /// </summary>
        [Description("工作进度")]
        public string WorkProgress { get; set; }
        /// <summary>
        /// 周数表Id 外键
        /// </summary>
        [Description("周数表Id 外键")]
        public int WeekReportFlagId { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [Description("备注")]
        public string Remark { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Description("创建时间")]
        public DateTime? CreateTime { get; set; }
    }
}
