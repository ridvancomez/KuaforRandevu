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
    public class EmployeeManager : GenericService<Employee>, IEmployeeService
    {
        public EmployeeManager(GenericRepository<Employee> repository) : base(repository)
        {
        }
    }
}
