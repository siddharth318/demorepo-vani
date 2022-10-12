using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TCS_API.Models;

namespace TCS_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : Controller
    {



        //This action will help in fetching the list of Hotels.


        [HttpGet]
        public List<Hotel> GetHotels()
        {
            List<Hotel> hotels = new List<Hotel>();
            try
            {
                
                hotels.Add(new Hotel() { HotelID = 1, HotelName = "Taj", CostPerDay = 20000 });
                hotels.Add(new Hotel() { HotelID = 2, HotelName = "Milan", CostPerDay = 21000 });
                hotels.Add(new Hotel() { HotelID = 3, HotelName = "Stay Inn", CostPerDay = 15000 });

            }
            catch (Exception)
            {

                hotels = null;
            }

            return hotels;

        }


    }
}
