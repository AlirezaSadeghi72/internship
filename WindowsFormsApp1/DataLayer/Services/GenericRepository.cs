using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DataLayer
{
    public class GenericRepository<T> where T : class
    {
        private dbEntities _db;
        private DbSet<T> _dbSet;

        public GenericRepository(dbEntities db)
        {
            _db = db;
            _dbSet = _db.Set<T>();
        }


        public IEnumerable<T> get(Expression<Func<T, bool>> where = null,
            Expression<Func<T, object>> orderBy = null
             , bool firstOrLirst = true, int? top = null)
        {
            IQueryable<T> result = _dbSet;
            if (where != null)
            {
                result = result.Where(where);
            }

            if (orderBy != null )
            {
                if (firstOrLirst)
                    result = result.OrderBy(orderBy);
                else
                    result = result.OrderByDescending(orderBy);
            }

            if (top != null)
            {
                result = result.Take((int)top);
            }

            return result.ToList();
        }

        public int? getMaxID(Expression<Func<T, int?>> max)
        {
            return _dbSet.Max(max);
        }

        public void insert(T Tentity)
        {
            _dbSet.Add(Tentity);
        }

    }
}
