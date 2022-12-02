using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit_of_Work_BusinessLayer.Abstract;
using Unit_of_Work_DataAccessLayer.Abstract;
using Unit_of_Work_DataAccessLayer.UnitOfWork;
using Unit_of_Work_EntityLayer.Concrete;

namespace Unit_of_Work_BusinessLayer.Concrete
{
    public class CustomerService : GenericService<Customer>, ICustomerService
    {
        public CustomerService(IGenericDal<Customer> genericDal, IUnitOfWorkDal unitOfWorkDal) : base(genericDal, unitOfWorkDal)
        {
        }
    }
}
