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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void TDelete(int id)
        {
            _contactDal.Delete(id);
        }

        public List<Contact> TGetAllList()
        {
            return _contactDal.GetAllList();
        }

        public Contact TGetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public void TInsert(Contact entity)
        {
            _contactDal.Insert(entity);
        }

        public void TUpdate(Contact entity)
        {
            _contactDal.Update(entity);
        }
    }
}
