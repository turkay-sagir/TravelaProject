﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelaProject.EntityLayer.Concrete
{
    public class Services
    {
        public int ServicesId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
        public bool Status { get; set; }
    }
}