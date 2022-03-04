using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Hotel
    {
        private int Hotelid;
        private string HotelName;
        private int AvgRatePerNight;
        private string Addr;
        private string Email;
        private int Rating;
        private string Fax;

        public int Hotelid1 { get => Hotelid; set => Hotelid = value; }
        public string HotelName1 { get => HotelName; set => HotelName = value; }
        public int AvgRatePerNight1 { get => AvgRatePerNight; set => AvgRatePerNight = value; }
        public string Addr1 { get => Addr; set => Addr = value; }
        public string Email1 { get => Email; set => Email = value; }
        public int Rating1 { get => Rating; set => Rating = value; }
        public string Fax1 { get => Fax; set => Fax = value; }
    }
}
