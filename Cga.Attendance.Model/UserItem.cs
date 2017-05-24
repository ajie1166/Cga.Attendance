using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cga.Attendance.Model
{
    public class UserItem
    {
        public int Id { get; set; }

        [StringLength(50)]
        [ForeignKey("User")]
        public string JobNum { get; set; }

        public User User { get; set; }

        public int? ItemId { get; set; }
    }
}
