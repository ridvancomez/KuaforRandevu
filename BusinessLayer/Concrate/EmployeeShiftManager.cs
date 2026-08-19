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
    public class EmployeeShiftManager : GenericService<EmployeeShift>, IEmployeeShiftService
    {
        public EmployeeShiftManager(GenericRepository<EmployeeShift> repository) : base(repository)
        {
        }
    }
}
