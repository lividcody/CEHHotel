using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CEHHotel.Models;

namespace CEHHotel.Data
{
    public class CEHHotelContext : DbContext
    {
        public CEHHotelContext (DbContextOptions<CEHHotelContext> options)
            : base(options)
        {
        }

        public DbSet<CEHHotel.Models.Guest> Guest { get; set; } = default!;
    }
}
