using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit_of_Work_BusinessLayer.Abstract;
using Unit_of_Work_DataAccessLayer.Abstract;
using Unit_of_Work_DataAccessLayer.UnitOfWork;

namespace Unit_of_Work_BusinessLayer.Concrete
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly IGenericDal<T> _genericDal;
        private readonly IUnitOfWorkDal _unitOfWorkDal;

        public GenericService(IGenericDal<T> genericDal, IUnitOfWorkDal unitOfWorkDal)
        {
            _genericDal = genericDal;
            _unitOfWorkDal = unitOfWorkDal;
        }

        public void TDelete(T t)
        {
            _genericDal.Delete(t);
            _unitOfWorkDal.Save();
        }

        public T TGetByID(int id)
        {
            return _genericDal.GetByID(id);
        }

        public List<T> TGetList()
        {
            return _genericDal.GetList();
        }

        public void TInsert(T t)
        {
            _genericDal.Insert(t);
            _unitOfWorkDal.Save();
        }

        public void TUpdate(T t)
        {
            _genericDal.Update(t);
            _unitOfWorkDal.Save();
        }

        public void TUpdateRange(List<T> t)
        {
            _genericDal.UpdateRange(t);
            _unitOfWorkDal.Save();
        }
    }
}
