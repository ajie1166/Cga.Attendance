using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cga.Attendance.Model
{
    /// <summary>
    /// 假期修改
    /// </summary>
    public class VacationLog
    {
        public int Id { get; set; }
        /// <summary>
        /// 工号
        /// </summary>
        [ForeignKey("User")]
        public string JobNum { get; set; }

        public User User { get; set; }
        /// <summary>
        /// 处理标题描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 处理时间
        /// </summary>
        public DateTime? OperaDateTime { get; set; }
        /// <summary>
        /// 处理的假期类型
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 处理了多少个小时
        /// </summary>
        public int Hours { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
