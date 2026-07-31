using System;
using System.Collections.Generic;
using System.Text;

namespace class_objects2
{
    class HotelBooking
    {
        public string GuestName { get; set; }
        public string RoomType { get; set; }
        public int Nights { get; set; }

        public HotelBooking()
        {
            GuestName = "Guest";
            RoomType = "Single Seater";
            Nights = 1;
        }
        public HotelBooking(string guestName, string roomType, int nights)
        {
            GuestName = guestName;
            RoomType = roomType;
            Nights = nights;
        }
        public HotelBooking(HotelBooking previousBooking)
        {
            GuestName = previousBooking.GuestName;
            RoomType = previousBooking.RoomType;
            Nights = previousBooking.Nights;
        }

        public void display()
        {
            Console.WriteLine("====================================");
            Console.WriteLine($"Guest Name: {GuestName} RoomType: {RoomType} Nights: {Nights}");
        }
    }

}
