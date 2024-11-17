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
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public void TDelete(int id)
        {
            _socialMediaDal.Delete(id);
        }

        public List<SocialMedia> TGetAllList()
        {
            return _socialMediaDal.GetAllList();
        }

        public SocialMedia TGetById(int id)
        {
            return _socialMediaDal.GetById(id);
        }

        public void TInsert(SocialMedia entity)
        {
            _socialMediaDal.Insert(entity);
        }

        public void TUpdate(SocialMedia entity)
        {
            _socialMediaDal.Update(entity);
        }
    }
}
