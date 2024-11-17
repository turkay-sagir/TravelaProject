using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelaProject.BusinessLayer.Abstract;
using TravelaProject.DataAccessLayer.Abstract;
using TravelaProject.EntityLayer.Concrete;

namespace TravelaProject.BusinessLayer.Concrete
{
    public class ServicesManager : IServicesService
    {
        private readonly IServicesDal _servicesDal;

        public ServicesManager(IServicesDal servicesDal)
        {
            _servicesDal = servicesDal;
        }

        public void TDelete(int id)
        {
            _servicesDal.Delete(id);
        }

        public List<Services> TGetAllList()
        {
            return _servicesDal.GetAllList();
        }

        public Services TGetById(int id)
        {
            return _servicesDal.GetById(id);
        }

        public void TInsert(Services entity)
        {
            _servicesDal.Insert(entity);
        }

        public void TUpdate(Services entity)
        {
            _servicesDal.Update(entity);
        }
    }
}
