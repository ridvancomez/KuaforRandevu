using BusinessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class AppointmentManager : GenericService<Appointment>, IAppointmentService
    {
        public AppointmentManager(GenericRepository<Appointment> repository) : base(repository)
        {
        }
    }
}
