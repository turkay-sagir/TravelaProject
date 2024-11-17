using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelaProject.DataAccessLayer.Abstract;
using TravelaProject.DataAccessLayer.Context;

namespace TravelaProject.DataAccessLayer.Repositories
{
    public class GenericRepositories<T> : IGenericDal<T> where T : class
    {
        private readonly TravelaProjectContext _context;

        public GenericRepositories(TravelaProjectContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            var value = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(value);
            _context.SaveChanges();

        }

        public List<T> GetAllList()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}
