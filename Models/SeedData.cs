using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CEHHotel.Data;
using CEHHotel.Models;

namespace CEHHotel.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CEHHotelContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CEHHotelContext>>()))
            {
                // Look for any movies.
                if (context.Guest.Any())
                {
                    return;   // DB has been seeded
                }

                context.Guest.AddRange(
                    new Guest
                    {
                        FirstName = "Sim",
                        LastName = "Swain",
                        Phone = "641-555-5555",
                        CheckInDate = DateTime.Parse("2023-2-3"),
                        CheckOutDate = DateTime.Parse("2023-2-5"),
                        CreditCardNum = "1234567812345678",
                        PhotoId = null
                    },

                    new Guest
                    {
                        FirstName = "Cody",
                        LastName = "Henderson",
                        Phone = "641-777-0654",
                        CheckInDate = DateTime.Parse("2023-5-5"),
                        CheckOutDate = DateTime.Parse("2023-5-7"),
                        CreditCardNum = "4378934529810453",
                        PhotoId = null
                    },

                    new Guest
                    {
                        FirstName = "Drakan",
                        LastName = "Swain",
                        Phone = "641-555-6666",
                        CheckInDate = DateTime.Parse("2023-1-27"),
                        CheckOutDate = DateTime.Parse("2023-1-29"),
                        CreditCardNum = "9234567912345679",
                        PhotoId = null
                    },

                    new Guest
                    {
                        FirstName = "Billy",
                        LastName = "Jack",
                        Phone = "555-444-3333",
                        CheckInDate = DateTime.Parse("2023-8-12"),
                        CheckOutDate = DateTime.Parse("2023-8-15"),
                        CreditCardNum = "1111222233334444",
                        PhotoId = null
                    }
                ) ;
                context.SaveChanges();
            }
        }
    }
}
