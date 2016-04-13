using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace WebServiceAdvanced.Controllers
{
    public class HotelRoomController : ApiController
    {
        private ViewContext db = new ViewContext();

        // GET: api/HotelRoom
        [HttpGet]
        public IEnumerable<string> Foo1()
        {
            return new string[] { "Foo1", "value1" };
        }

        // GET: api/HotelRoom/1
        [ResponseType(typeof(HotelRoom))]
        public IHttpActionResult Get(string hotelName)
        {
            HotelRoom hotel = db.HotelRooms.Find(hotelName);
            if (hotel == null)
            {
                return NotFound();
            }

            return Ok(hotel);
        }

    }
}
