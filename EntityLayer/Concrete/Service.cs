using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Service
    {
        [Key]
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public int ServiceTime { get; set; }
        public decimal ServicePrice { get; set; }   // float yerine decimal
        public string ServiceDescription { get; set; }
        public string ServiceImage { get; set; }

        // Navigation property - bir hizmet birden çok randevuda kullanılabilir
        public ICollection<Appointment>? Appointments { get; set; }
    }
}
