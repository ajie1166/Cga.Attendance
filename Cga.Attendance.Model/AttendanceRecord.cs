using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cga.Attendance.Model
{
    /// <summary>
    /// 考勤记录表
    /// </summary>
    public class AttendanceRecord
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 工号
        /// </summary>
        [ForeignKey("User")]
        public string JobNum { get; set; }

        public User User { get; set; }
        /// <summary>
        /// 初始上班时间
        /// </summary>
        public DateTime InitWorkStartTime { get; set; }
        /// <summary>
        /// 初始下班时间
        /// </summary>
        public DateTime InitWorkEndTime { get; set; }
        /// <summary>
        /// 实际上班时间
        /// </summary>
        public DateTime ActualStartTime { get; set; }
        /// <summary>
        /// 实际下班时间
        /// </summary>
        public DateTime ActualEndTime { get; set; }
        /// <summary>
        ///  排班类型(1常日班;0公休;)
        /// </summary>
        public int SchedulingType { get; set; }
        /// <summary>
        /// 考勤日期 
        /// </summary>
        public DateTime AttendaceDate { get; set; }
        /// <summary>
        /// 考勤类型 打卡类型(0 打卡机;1 人工处理)
        /// </summary>
        public int AttandanceType { get; set; }
        /// <summary>
        /// 出勤状态(总的异常状态;1正常;0默认;-1异常)
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 上午异常状态
        /// </summary>
        public int ExceptionOne { get; set; }
        /// <summary>
        /// 下午异常状态
        /// </summary>
        public int ExceptionTwo { get; set; }
        /// <summary>
        /// 工作天数(最多为1.5;正常为1;半天为0.5)
        /// </summary>
        public double WorkDays { get; set; }
        /// <summary>
        /// 处理人
        /// </summary>
        public string OperateJobNum { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }

    }
}
