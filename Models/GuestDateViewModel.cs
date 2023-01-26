using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace CEHHotel.Models

{
    public class GuestDateViewModel
    {
        public List<Guest>? Guests { get; set; }
        public SelectList? CheckInDates { get; set; }
        public DateTime? GuestCheckInDate { get; set; }
        public DateTime? SearchString { get; set; }
    }
}
