using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class EmployeeShift
    {
        [Key]
        public int EmployeeShiftID { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        public Employee? Employee { get; set; }

        public int DayNo { get; set; }        // 1-7 (Pazartesi-Pazar)
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
