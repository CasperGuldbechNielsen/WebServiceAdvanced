using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WebServiceAdvanced;

namespace AdvancedWSConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ServerUrl = "http://localhost:8072";
            HttpClientHandler handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;
            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(ServerUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    Console.WriteLine("api/hotels");
                    var responseHotels = client.GetAsync("api/hotels").Result;
                    if (responseHotels.IsSuccessStatusCode)
                    {
                        IEnumerable<Hotel> hotels = responseHotels.Content.ReadAsAsync<IEnumerable<Hotel>>().Result;
                        foreach (var hotel in hotels)
                        {
                            Console.WriteLine(hotel);
                        }
                    }

                }
                catch (Exception)
                {
                    throw;
                }
                Console.ReadLine();

                Console.WriteLine("api/guestlists");
                var responseGuestList = client.GetAsync("api/guestlists").Result;
                if (responseGuestList.IsSuccessStatusCode)
                {
                    IEnumerable<Guestlist> guestlists = responseGuestList.Content.ReadAsAsync<IEnumerable<Guestlist>>().Result;
                    foreach (var guestlist in guestlists)
                    {
                        Console.WriteLine(guestlist);
                    }
                }

                Console.ReadKey();

                Console.WriteLine("api/HotelRoom");
                var responseHotelRoom = client.GetAsync("api/HotelRoom/" + "Prindsen").Result;
                if (responseHotelRoom.IsSuccessStatusCode)
                {
                    IEnumerable<HotelRoom> hotelRoom = responseHotelRoom.Content.ReadAsAsync<IEnumerable<HotelRoom>>().Result;
                    foreach (var hotel in hotelRoom)
                    {
                        Console.WriteLine(hotel);
                    }
                }

                Console.ReadKey();
            }

        }
    }
}
