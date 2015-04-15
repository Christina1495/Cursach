using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursach
{
    public class Tour
    {
        public string id;
        public string name;
        public string price;
        public string duration;
        public string resort;
        public string dateS;
        public string dateE;
    }
    public class TourList
    {
        public TourList() { }
        public List<Tour> list;
    }

    public class Hotel
    {
        public string id;
        public string name;
    }
    public class HotelList
    {
        public HotelList() { }
        public List<Hotel> list;
    }
}
