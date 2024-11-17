using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelaProject.DataAccessLayer.Abstract;
using TravelaProject.DataAccessLayer.Context;
using TravelaProject.DataAccessLayer.Repositories;
using TravelaProject.EntityLayer.Concrete;

namespace TravelaProject.DataAccessLayer.EntityFramework
{
    public class EfSocialMediaDal : GenericRepositories<SocialMedia>, ISocialMediaDal
    {
        public EfSocialMediaDal(TravelaProjectContext context) : base(context)
        {
        }



    }
}
