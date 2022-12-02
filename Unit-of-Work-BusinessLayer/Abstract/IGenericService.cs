using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_of_Work_BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TInsert(T t);
        void TDelete(T t);
        void TUpdateRange(List<T> t);
        void TUpdate(T t);
        List<T> TGetList();
        T TGetByID(int id);
    }
}
