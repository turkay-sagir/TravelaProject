﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelaProject.EntityLayer.Concrete
{
    public class SocialMedia
    {
        public int SocialMediaId { get; set; }
        public string PlatformName { get; set; }
        public string IconUrl { get; set; }
        public string RedirectUrl { get; set; }
        public bool Status { get; set; }
    }
}
