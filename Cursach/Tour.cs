using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursach
{
    /// <summary>
    /// Лист с Турами
    /// </summary>
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
    /// <summary>
    /// 
    /// </summary>
    public class TourList
    {
        public TourList() { }
        public List<Tour> list;
    }
    /// <summary>
    /// Лист с Отелями
    /// </summary>
    public class Hotel
    {
        public string id;
        public string name;
    }
    /// <summary>
    /// 
    /// </summary>
    public class HotelList
    {
        public HotelList() { }
        public List<Hotel> list;
    }
    /// <summary>
    /// Лист с Экскурсиями
    /// </summary>
    public class Excursion
    {
        public string id;
        public string name;
        public string price;
        public string duration;
        public string description;
        public string marks;
    }
    /// <summary>
    /// 
    /// </summary>
    public class ExcursionList
    {
        public ExcursionList() { }
        public List<Excursion> list;
    }
    /// <summary>
    /// Лист с информацией о пользователе
    /// </summary>
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
    /// <summary>
    /// 
    /// </summary>
    public class CustomerTourList
    {
        public CustomerTourList() { }
        public List<CustomerTour> list;
    }
    /// <summary>
    /// 
    /// </summary>
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
    /// <summary>
    /// 
    /// </summary>
    public class DiscountList
    {
        public DiscountList() { }
        public List<Discount> list;
    }
    /// <summary>
    /// 
    /// </summary>
    public class Date_Tour
    {
        public string idTour;
        public string price;
        public string nameTour;
        public string date;
    }
    /// <summary>
    /// 
    /// </summary>
    public class Date_TourList
    {
        public Date_TourList() { }
        public List<Date_Tour> list;
    }
}
