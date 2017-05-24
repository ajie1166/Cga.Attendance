using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cga.Attendance.Model
{
    /// <summary>
    /// 部门
    /// </summary>
    public class Department
    {
        public int Id { get; set; }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string DepartmentName { get; set; }
        /// <summary>
        /// 部门主管工号
        /// </summary>
        [ForeignKey("User")]
        public string SupervisorjobNum { get; set; }

        /// <summary>
        /// 用户
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// 上级部门Id
        /// </summary>
        public int ParentId { get; set; }
        /// <summary>
        /// 部门描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        ///创建时间 
        /// </summary>
        public DateTime? CreateTime { get; set; }
    }
}
