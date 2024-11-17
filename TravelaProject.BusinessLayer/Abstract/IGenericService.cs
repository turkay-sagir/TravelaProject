using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelaProject.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TDelete (int id);
        void TInsert (T entity);
        void TUpdate (T entity);
        T TGetById (int id);
        List<T> TGetAllList ();
    }
}
