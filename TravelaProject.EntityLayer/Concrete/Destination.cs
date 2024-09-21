using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelaProject.EntityLayer.Concrete
{
    public class Destination
    {
        public int DestinationId { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public byte Day { get; set; }
        public byte Person { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public bool Status { get; set; }
    }
}
