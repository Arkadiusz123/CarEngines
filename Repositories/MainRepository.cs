using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CarEngines
{
    public class MainRepository<T> : IMainRepository<T> where T : class
    {
        private readonly EngineContext _context;
        private readonly DbSet<T> _dbSet;

        public MainRepository(EngineContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }


        public ICollection<T> GetFullList()
        {
            return _dbSet.ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public T FindByID(int? id)
        {
            return _dbSet.Find(id);
        }

        public void AddElement(T entity)
        {
            _dbSet.Add(entity);
        }

        public void UpdateElement(T entity)
        {
            _dbSet.Update(entity);
        }

        public void DeleteElement(T entity)
        {
            _dbSet.Remove(entity);
        }
    }
}
