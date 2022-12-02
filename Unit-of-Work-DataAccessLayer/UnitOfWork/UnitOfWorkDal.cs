using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit_of_Work_DataAccessLayer.Concrete;

namespace Unit_of_Work_DataAccessLayer.UnitOfWork
{
    public class UnitOfWorkDal : IUnitOfWorkDal
    {
        private readonly Context _context;

        public UnitOfWorkDal(Context context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
