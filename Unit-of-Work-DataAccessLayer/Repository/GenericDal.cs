using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit_of_Work_DataAccessLayer.Abstract;
using Unit_of_Work_DataAccessLayer.Concrete;

namespace Unit_of_Work_DataAccessLayer.Repository
{
    public class GenericDal<T> : IGenericDal<T> where T : class
    {
        protected readonly Context _context;
        protected readonly DbSet<T> _dbSet;

        public GenericDal(Context context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Delete(T t)
        {
            _dbSet.Remove(t);
        }

        public T GetByID(int id)
        {
            return _dbSet.Find(id);
        }

        public List<T> GetList()
        {
            return _dbSet.ToList();
        }

        public void Insert(T t)
        {
            _dbSet.Add(t);
        }

        public void Update(T t)
        {
            _dbSet.Update(t);
        }

        public void UpdateRange(List<T> t)
        {
            _dbSet.UpdateRange(t);
        }
    }
}
