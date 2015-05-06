﻿using System;
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

    public class Excursion
    {
        public string id;
        public string name;
        public string price;
        public string duration;
        public string description;
        public string marks;
    }
    public class ExcursionList
    {
        public ExcursionList() { }
        public List<Excursion> list;
    }

    public class CustomerTour
    {
        public string id;
        public string nameTour;
        public string price;
        public string date;
        public string contract;
        public string status;
        public string paid;
        public string idTour;
    }
    public class CustomerTourList
    {
        public CustomerTourList() { }
        public List<CustomerTour> list;
    }

    public class Discount
    {
        public string id;
        public string nameTour;
        public string price;
        public string nameResort;
        public string discount;
        public string description;
        public string idResort;
    }
    public class DiscountList
    {
        public DiscountList() { }
        public List<Discount> list;
    }

    public class Date_Tour
    {
        public string idTour;
        public string price;
        public string nameTour;
        public string date;
    }
    public class Date_TourList
    {
        public Date_TourList() { }
        public List<Date_Tour> list;
    }
}
