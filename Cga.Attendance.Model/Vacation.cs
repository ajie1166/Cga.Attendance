using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cga.Attendance.Model
{
    /// <summary>
    /// '员工假期数据表';
    /// </summary>
    public class Vacation
    {
        public int Id { get; set; }
        /// <summary>
        /// 工号
        /// </summary>
        public string JobNum { get; set; }
        /// <summary>
        /// '假期类型,1为调休，2为年假，3为全薪病假',
        /// </summary>
        public int VacationId { get; set; }
        /// <summary>
        /// 过期时间
        /// </summary>
        [Column(TypeName = "Date")]
        public DateTime Expirdate { get; set; }
        /// <summary>
        /// 假期/调休剩余时长
        /// </summary>
        public int Hours { get; set; }
    }
}
