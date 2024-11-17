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
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void TDelete(int id)
        {
            _aboutDal.Delete(id);
        }

        public List<About> TGetAllList()
        {
            return _aboutDal.GetAllList();
        }

        public About TGetById(int id)
        {
            return _aboutDal.GetById(id);
        }

        public void TInsert(About entity)
        {
            _aboutDal.Insert(entity);
        }

        public void TUpdate(About entity)
        {
            _aboutDal.Update(entity);
        }
    }
}
