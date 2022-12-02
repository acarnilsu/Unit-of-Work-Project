using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit_of_Work_DataAccessLayer.Abstract;
using Unit_of_Work_DataAccessLayer.Concrete;
using Unit_of_Work_DataAccessLayer.Repository;
using Unit_of_Work_EntityLayer.Concrete;

namespace Unit_of_Work_DataAccessLayer.EntityFramework
{
    public class EfCustomerDal : GenericDal<Customer>, ICustomerDal
    {
        public EfCustomerDal(Context context) : base(context)
        {
        }
    }
}
