using System.Collections.Generic;

namespace CarEngines
{
    public interface IMainRepository<T> where T : class
    {
        void AddElement(T entity);
        void DeleteElement(T entity);
        T FindByID(int? id);
        ICollection<T> GetFullList();
        void Save();
        void UpdateElement(T entity);
    }
}