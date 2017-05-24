using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cga.Attendance.Model
{
    /// <summary>
    /// 申请表
    /// </summary>
    public class ApplyRecord
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 工号
        /// </summary>
        //[ForeignKey("User")] //放在外键上就必须声明 关联哪个类
        public string JobNum { get; set; }
        /// <summary>
        /// 用户
        /// </summary>
        [ForeignKey("JobNum")] //放在关联类上就必须声明 哪个字段是外键
        public User User { get; set; }
        /// <summary>
        /// 公司
        /// </summary>
        public int CompanyId { get; set; }
        /// <summary>
        /// 部门Id
        /// </summary>
        public int DepartmentId { get; set; }
        /// <summary>
        /// 主管工号
        /// </summary>
        public int SupervisorJobNum { get; set; }
        /// <summary>
        /// 假期类型
        /// </summary>
        public int VacationType { get; set; }
        /// <summary>
        /// 假期主题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 理由
        /// </summary>
        public string Reason { get; set; }
        /// <summary>
        /// 假期开始时间
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 假期结束时间
        /// </summary>
        public DateTime EndTime { get; set; }
        /// <summary>
        /// 附件地址
        /// </summary>
        public string AttachUrl { get; set; }
        /// <summary>
        /// 申请小时数
        /// </summary>
        public int Hours { get; set; }
        /// <summary>
        /// 正在审批的人工号
        /// </summary>
        public string ApprovingJobNum { get; set; }
        /// <summary>
        /// 已审批人工号
        /// </summary>
        public string ApprovedJobNums { get; set; }
        /// <summary>
        /// 需要审批人工号
        /// </summary>
        public string NeedApproveJobNum { get; set; }
        /// <summary>
        /// 同意外出人员
        /// </summary>
        public string Members { get; set; }
        /// <summary>
        /// 审批状态
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }

    }
}
