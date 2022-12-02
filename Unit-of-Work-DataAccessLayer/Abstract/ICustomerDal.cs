using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit_of_Work_EntityLayer.Concrete;

namespace Unit_of_Work_DataAccessLayer.Abstract
{
    public interface ICustomerDal:IGenericDal<Customer>
    {
    }
}
