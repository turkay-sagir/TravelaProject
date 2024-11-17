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
    public class DestinationManager : IDestinationService
    {
        private readonly IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public void TDelete(int id)
        {
            _destinationDal.Delete(id);
        }

        public List<Destination> TGetAllList()
        {
            return _destinationDal.GetAllList();
        }

        public Destination TGetById(int id)
        {
            return _destinationDal.GetById(id);
        }

        public void TInsert(Destination entity)
        {
            _destinationDal.Insert(entity);
        }

        public void TUpdate(Destination entity)
        {
            _destinationDal.Update(entity);
        }
    }
}
