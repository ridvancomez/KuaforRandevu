using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Appointment
    {
        [Key]
        public int AppointmentID { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public Customer? Customer { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        public Employee? Employee { get; set; }

        [ForeignKey("Service")]
        public int ServiceID { get; set; }
        public Service? Service { get; set; }

        public DateTime AppointmentDate { get; set; }   // sadece tarih (gün)
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public string Status { get; set; } = "Beklemede"; // Beklemede / Onaylandı / İptal

        public string Note { get; set; }
    }
}
