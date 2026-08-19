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
    public class ServiceManager : GenericService<Service>, IServiceService
    {
        public ServiceManager(GenericRepository<Service> repository) : base(repository)
        {
        }
    }
}
