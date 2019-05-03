using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using cinema.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cinema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        static List<Film> films;

        public FilmController()
        {
            if (films == null)
            {
                films = new List<Film>()
                {
                    new Film()
                    {
                        Id = 1,
                        Name = "Rembo",
                        DateTimePlaces = GetDateTimePlaces()
                    },
                    new Film()
                    {
                        Id = 2,
                        Name = "Venom",
                        DateTimePlaces  = GetDateTimePlaces()
                    },
                    new Film()
                    {
                        Id = 3,
                        Name = "Marvel",
                        DateTimePlaces  = GetDateTimePlaces()
                    }

                };
            }
        }



        // GET: api/Film
        [HttpGet]
        public IEnumerable<Film> Get()
        {
            return films;
        }

        // GET: api/Film/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Film
        [HttpPost]
        public void Post([FromBody] Film film)
        {
            films.Add(film);
        }

        // PUT: api/Film/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/FILm/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var removedFIlm = films.First(x => x.Id == id);
            films.Remove(removedFIlm);
        }

        // GET: api/Film/GetPlaces
        [HttpGet("{id}/GetPlaces")]
        public IEnumerable<Place> GetPlaces()
        {
            return null;
        }

        // Post: api/Film/AddReserve
        [HttpPost("[action]")]
        public void AddReserve([FromBody] TransferModel model)
        {
            if (films != null)

            {
                var film = films.FirstOrDefault(x => x.Id == model.FilmId);
                var dateTimePlaces = film.DateTimePlaces;
                var year = Convert.ToInt32(model.Date.Split('-')[0]);
                var month = Convert.ToInt32(model.Date.Split('-')[1]);
                var day = Convert.ToInt32(model.Date.Split('-')[2].Split("T")[0]);
                var hour = Convert.ToInt32(model.Date.Split('T')[1].Split(":")[0]);
                var minute = Convert.ToInt32(model.Date.Split('T')[1].Split(":")[1]);
                var second = Convert.ToInt32(model.Date.Split('T')[1].Split(":")[2]);
                var date = new DateTime(Convert.ToInt32(model.Date.Split('-')[0])
                    , Convert.ToInt32(model.Date.Split('-')[1])
                    , Convert.ToInt32(model.Date.Split('-')[2].Split("T")[0])
                    , Convert.ToInt32(model.Date.Split('T')[1].Split(":")[0])
                    , Convert.ToInt32(model.Date.Split('T')[1].Split(":")[1])
                    , Convert.ToInt32(model.Date.Split('T')[1].Split(":")[2]));
                var dateTimePlace =
                    dateTimePlaces.FirstOrDefault(x => x.dateTime == date);
                var place = dateTimePlace.places.FirstOrDefault(x => x.Id == model.PlaceId);
                place.IsReserved = true;
            }
        }

        public List<Place> GetPlacesList()
        {
            return new List<Place>()
            {
                new Place() {Id = 1, Row = 1, Number = 1, IsReserved = false},
                new Place() {Id = 2, Row = 1, Number = 1, IsReserved = false},
                new Place() {Id = 3, Row = 1, Number = 2, IsReserved = false},
                new Place() {Id = 4, Row = 1, Number = 3, IsReserved = false},
                new Place() {Id = 5, Row = 1, Number = 4, IsReserved = false},
                new Place() {Id = 6, Row = 1, Number = 5, IsReserved = false},
                new Place() {Id = 7, Row = 1, Number = 6, IsReserved = false},
                new Place() {Id = 8, Row = 1, Number = 7, IsReserved = false},
                new Place() {Id = 9, Row = 2, Number = 1, IsReserved = false},
                new Place() {Id = 10, Row = 2, Number = 1, IsReserved = false},
                new Place() {Id = 11, Row = 2, Number = 2, IsReserved = false},
                new Place() {Id = 12, Row = 2, Number = 3, IsReserved = false},
                new Place() {Id = 13, Row = 2, Number = 4, IsReserved = false},
                new Place() {Id = 14, Row = 2, Number = 5, IsReserved = false},
                new Place() {Id = 15, Row = 2, Number = 6, IsReserved = false},
                new Place() {Id = 16, Row = 2, Number = 7, IsReserved = false},
                new Place() {Id = 17, Row = 3, Number = 1, IsReserved = false},
                new Place() {Id = 18, Row = 3, Number = 2, IsReserved = false},
                new Place() {Id = 19, Row = 3, Number = 3, IsReserved = false},
                new Place() {Id = 20, Row = 3, Number = 4, IsReserved = false},
                new Place() {Id = 21, Row = 3, Number = 5, IsReserved = false},
                new Place() {Id = 22, Row = 3, Number = 6, IsReserved = false},
                new Place() {Id = 23, Row = 3, Number = 7, IsReserved = false},
                new Place() {Id = 24, Row = 4, Number = 1, IsReserved = false},
                new Place() {Id = 25, Row = 4, Number = 2, IsReserved = false},
                new Place() {Id = 26, Row = 4, Number = 3, IsReserved = false},
                new Place() {Id = 27, Row = 4, Number = 4, IsReserved = false},
                new Place() {Id = 28, Row = 4, Number = 5, IsReserved = false},
                new Place() {Id = 29, Row = 4, Number = 6, IsReserved = false},
                new Place() {Id = 30, Row = 4, Number = 7, IsReserved = false},
                new Place() {Id = 31, Row = 5, Number = 1, IsReserved = false},
                new Place() {Id = 32, Row = 5, Number = 2, IsReserved = false},
                new Place() {Id = 33, Row = 5, Number = 3, IsReserved = false},
                new Place() {Id = 34, Row = 5, Number = 4, IsReserved = false},
                new Place() {Id = 35, Row = 5, Number = 5, IsReserved = false},
                new Place() {Id = 36, Row = 5, Number = 6, IsReserved = false},
                new Place() {Id = 37, Row = 5, Number = 7, IsReserved = false},
            };
        }

        public List<DateTimePlace> GetDateTimePlaces()
        {
            return new List<DateTimePlace>()
            {
                new DateTimePlace()
                {
                    dateTime = new DateTime(2019, 04, 15, 15, 0, 0, 0),
                    places = new List<Place>()
                    { new Place() {Id = 1, Row = 1, Number = 1, IsReserved = false},
                new Place() {Id = 2, Row = 1, Number = 1, IsReserved = false},
                new Place() {Id = 3, Row = 1, Number = 2, IsReserved = false},
                new Place() {Id = 4, Row = 1, Number = 3, IsReserved = false},
                new Place() {Id = 5, Row = 1, Number = 4, IsReserved = false},
                new Place() {Id = 6, Row = 1, Number = 5, IsReserved = false},
                new Place() {Id = 7, Row = 1, Number = 6, IsReserved = false},
                new Place() {Id = 8, Row = 1, Number = 7, IsReserved = false},
                new Place() {Id = 9, Row = 2, Number = 1, IsReserved = false},
                new Place() {Id = 10, Row = 2, Number = 1, IsReserved = false},
                new Place() {Id = 11, Row = 2, Number = 2, IsReserved = false},
                new Place() {Id = 12, Row = 2, Number = 3, IsReserved = false},
                new Place() {Id = 13, Row = 2, Number = 4, IsReserved = false},
                new Place() {Id = 14, Row = 2, Number = 5, IsReserved = false},
                new Place() {Id = 15, Row = 2, Number = 6, IsReserved = false},
                new Place() {Id = 16, Row = 2, Number = 7, IsReserved = false},
                new Place() {Id = 17, Row = 3, Number = 1, IsReserved = false},
                new Place() {Id = 18, Row = 3, Number = 2, IsReserved = false},
                new Place() {Id = 19, Row = 3, Number = 3, IsReserved = false},
                new Place() {Id = 20, Row = 3, Number = 4, IsReserved = false},
                new Place() {Id = 21, Row = 3, Number = 5, IsReserved = false},
                new Place() {Id = 22, Row = 3, Number = 6, IsReserved = false},
                new Place() {Id = 23, Row = 3, Number = 7, IsReserved = false},
                new Place() {Id = 24, Row = 4, Number = 1, IsReserved = false},
                new Place() {Id = 25, Row = 4, Number = 2, IsReserved = false},
                new Place() {Id = 26, Row = 4, Number = 3, IsReserved = false},
                new Place() {Id = 27, Row = 4, Number = 4, IsReserved = false},
                new Place() {Id = 28, Row = 4, Number = 5, IsReserved = false},
                new Place() {Id = 29, Row = 4, Number = 6, IsReserved = false},
                new Place() {Id = 30, Row = 4, Number = 7, IsReserved = false},
                new Place() {Id = 31, Row = 5, Number = 1, IsReserved = false},
                new Place() {Id = 32, Row = 5, Number = 2, IsReserved = false},
                new Place() {Id = 33, Row = 5, Number = 3, IsReserved = false},
                new Place() {Id = 34, Row = 5, Number = 4, IsReserved = false},
                new Place() {Id = 35, Row = 5, Number = 5, IsReserved = false},
                new Place() {Id = 36, Row = 5, Number = 6, IsReserved = false},
                new Place() {Id = 37, Row = 5, Number = 7, IsReserved = false},
            }
                },
                new DateTimePlace()
                {
                    dateTime = new DateTime(2019, 04, 19, 13, 0, 0, 0),
                    places = new List<Place>()
                    { new Place() {Id = 1, Row = 1, Number = 1, IsReserved = false},
                new Place() {Id = 2, Row = 1, Number = 1, IsReserved = false},
                new Place() {Id = 3, Row = 1, Number = 2, IsReserved = false},
                new Place() {Id = 4, Row = 1, Number = 3, IsReserved = false},
                new Place() {Id = 5, Row = 1, Number = 4, IsReserved = false},
                new Place() {Id = 6, Row = 1, Number = 5, IsReserved = false},
                new Place() {Id = 7, Row = 1, Number = 6, IsReserved = false},
                new Place() {Id = 8, Row = 1, Number = 7, IsReserved = false},
                new Place() {Id = 9, Row = 2, Number = 1, IsReserved = false},
                new Place() {Id = 10, Row = 2, Number = 1, IsReserved = false},
                new Place() {Id = 11, Row = 2, Number = 2, IsReserved = false},
                new Place() {Id = 12, Row = 2, Number = 3, IsReserved = false},
                new Place() {Id = 13, Row = 2, Number = 4, IsReserved = false},
                new Place() {Id = 14, Row = 2, Number = 5, IsReserved = false},
                new Place() {Id = 15, Row = 2, Number = 6, IsReserved = false},
                new Place() {Id = 16, Row = 2, Number = 7, IsReserved = false},
                new Place() {Id = 17, Row = 3, Number = 1, IsReserved = false},
                new Place() {Id = 18, Row = 3, Number = 2, IsReserved = false},
                new Place() {Id = 19, Row = 3, Number = 3, IsReserved = false},
                new Place() {Id = 20, Row = 3, Number = 4, IsReserved = false},
                new Place() {Id = 21, Row = 3, Number = 5, IsReserved = false},
                new Place() {Id = 22, Row = 3, Number = 6, IsReserved = false},
                new Place() {Id = 23, Row = 3, Number = 7, IsReserved = false},
                new Place() {Id = 24, Row = 4, Number = 1, IsReserved = false},
                new Place() {Id = 25, Row = 4, Number = 2, IsReserved = false},
                new Place() {Id = 26, Row = 4, Number = 3, IsReserved = false},
                new Place() {Id = 27, Row = 4, Number = 4, IsReserved = false},
                new Place() {Id = 28, Row = 4, Number = 5, IsReserved = false},
                new Place() {Id = 29, Row = 4, Number = 6, IsReserved = false},
                new Place() {Id = 30, Row = 4, Number = 7, IsReserved = false},
                new Place() {Id = 31, Row = 5, Number = 1, IsReserved = false},
                new Place() {Id = 32, Row = 5, Number = 2, IsReserved = false},
                new Place() {Id = 33, Row = 5, Number = 3, IsReserved = false},
                new Place() {Id = 34, Row = 5, Number = 4, IsReserved = false},
                new Place() {Id = 35, Row = 5, Number = 5, IsReserved = false},
                new Place() {Id = 36, Row = 5, Number = 6, IsReserved = false},
                new Place() {Id = 37, Row = 5, Number = 7, IsReserved = false},
            }
                },
                new DateTimePlace()
                {
                    dateTime = new DateTime(2019, 04, 16, 13, 0, 0, 0),
                    places = new List<Place>()
                    { new Place() {Id = 1, Row = 1, Number = 1, IsReserved = false},
                new Place() {Id = 2, Row = 1, Number = 1, IsReserved = false},
                new Place() {Id = 3, Row = 1, Number = 2, IsReserved = false},
                new Place() {Id = 4, Row = 1, Number = 3, IsReserved = false},
                new Place() {Id = 5, Row = 1, Number = 4, IsReserved = false},
                new Place() {Id = 6, Row = 1, Number = 5, IsReserved = false},
                new Place() {Id = 7, Row = 1, Number = 6, IsReserved = false},
                new Place() {Id = 8, Row = 1, Number = 7, IsReserved = false},
                new Place() {Id = 9, Row = 2, Number = 1, IsReserved = false},
                new Place() {Id = 10, Row = 2, Number = 1, IsReserved = false},
                new Place() {Id = 11, Row = 2, Number = 2, IsReserved = false},
                new Place() {Id = 12, Row = 2, Number = 3, IsReserved = false},
                new Place() {Id = 13, Row = 2, Number = 4, IsReserved = false},
                new Place() {Id = 14, Row = 2, Number = 5, IsReserved = false},
                new Place() {Id = 15, Row = 2, Number = 6, IsReserved = false},
                new Place() {Id = 16, Row = 2, Number = 7, IsReserved = false},
                new Place() {Id = 17, Row = 3, Number = 1, IsReserved = false},
                new Place() {Id = 18, Row = 3, Number = 2, IsReserved = false},
                new Place() {Id = 19, Row = 3, Number = 3, IsReserved = false},
                new Place() {Id = 20, Row = 3, Number = 4, IsReserved = false},
                new Place() {Id = 21, Row = 3, Number = 5, IsReserved = false},
                new Place() {Id = 22, Row = 3, Number = 6, IsReserved = false},
                new Place() {Id = 23, Row = 3, Number = 7, IsReserved = false},
                new Place() {Id = 24, Row = 4, Number = 1, IsReserved = false},
                new Place() {Id = 25, Row = 4, Number = 2, IsReserved = false},
                new Place() {Id = 26, Row = 4, Number = 3, IsReserved = false},
                new Place() {Id = 27, Row = 4, Number = 4, IsReserved = false},
                new Place() {Id = 28, Row = 4, Number = 5, IsReserved = false},
                new Place() {Id = 29, Row = 4, Number = 6, IsReserved = false},
                new Place() {Id = 30, Row = 4, Number = 7, IsReserved = false},
                new Place() {Id = 31, Row = 5, Number = 1, IsReserved = false},
                new Place() {Id = 32, Row = 5, Number = 2, IsReserved = false},
                new Place() {Id = 33, Row = 5, Number = 3, IsReserved = false},
                new Place() {Id = 34, Row = 5, Number = 4, IsReserved = false},
                new Place() {Id = 35, Row = 5, Number = 5, IsReserved = false},
                new Place() {Id = 36, Row = 5, Number = 6, IsReserved = false},
                new Place() {Id = 37, Row = 5, Number = 7, IsReserved = false},
            }
                },
                new DateTimePlace()
                {
                    dateTime = new DateTime(2019, 04, 16, 15, 0, 0, 0),
                    places = new List<Place>()
                    { new Place() {Id = 1, Row = 1, Number = 1, IsReserved = false},
                new Place() {Id = 2, Row = 1, Number = 1, IsReserved = false},
                new Place() {Id = 3, Row = 1, Number = 2, IsReserved = false},
                new Place() {Id = 4, Row = 1, Number = 3, IsReserved = false},
                new Place() {Id = 5, Row = 1, Number = 4, IsReserved = false},
                new Place() {Id = 6, Row = 1, Number = 5, IsReserved = false},
                new Place() {Id = 7, Row = 1, Number = 6, IsReserved = false},
                new Place() {Id = 8, Row = 1, Number = 7, IsReserved = false},
                new Place() {Id = 9, Row = 2, Number = 1, IsReserved = false},
                new Place() {Id = 10, Row = 2, Number = 1, IsReserved = false},
                new Place() {Id = 11, Row = 2, Number = 2, IsReserved = false},
                new Place() {Id = 12, Row = 2, Number = 3, IsReserved = false},
                new Place() {Id = 13, Row = 2, Number = 4, IsReserved = false},
                new Place() {Id = 14, Row = 2, Number = 5, IsReserved = false},
                new Place() {Id = 15, Row = 2, Number = 6, IsReserved = false},
                new Place() {Id = 16, Row = 2, Number = 7, IsReserved = false},
                new Place() {Id = 17, Row = 3, Number = 1, IsReserved = false},
                new Place() {Id = 18, Row = 3, Number = 2, IsReserved = false},
                new Place() {Id = 19, Row = 3, Number = 3, IsReserved = false},
                new Place() {Id = 20, Row = 3, Number = 4, IsReserved = false},
                new Place() {Id = 21, Row = 3, Number = 5, IsReserved = false},
                new Place() {Id = 22, Row = 3, Number = 6, IsReserved = false},
                new Place() {Id = 23, Row = 3, Number = 7, IsReserved = false},
                new Place() {Id = 24, Row = 4, Number = 1, IsReserved = false},
                new Place() {Id = 25, Row = 4, Number = 2, IsReserved = false},
                new Place() {Id = 26, Row = 4, Number = 3, IsReserved = false},
                new Place() {Id = 27, Row = 4, Number = 4, IsReserved = false},
                new Place() {Id = 28, Row = 4, Number = 5, IsReserved = false},
                new Place() {Id = 29, Row = 4, Number = 6, IsReserved = false},
                new Place() {Id = 30, Row = 4, Number = 7, IsReserved = false},
                new Place() {Id = 31, Row = 5, Number = 1, IsReserved = false},
                new Place() {Id = 32, Row = 5, Number = 2, IsReserved = false},
                new Place() {Id = 33, Row = 5, Number = 3, IsReserved = false},
                new Place() {Id = 34, Row = 5, Number = 4, IsReserved = false},
                new Place() {Id = 35, Row = 5, Number = 5, IsReserved = false},
                new Place() {Id = 36, Row = 5, Number = 6, IsReserved = false},
                new Place() {Id = 37, Row = 5, Number = 7, IsReserved = false},
            }
                },
                new DateTimePlace()
                {
                    dateTime = new DateTime(2019, 04, 16, 19, 0, 0, 0),
                    places = new List<Place>()
                    { new Place() {Id = 1, Row = 1, Number = 1, IsReserved = false},
                new Place() {Id = 2, Row = 1, Number = 1, IsReserved = false},
                new Place() {Id = 3, Row = 1, Number = 2, IsReserved = false},
                new Place() {Id = 4, Row = 1, Number = 3, IsReserved = false},
                new Place() {Id = 5, Row = 1, Number = 4, IsReserved = false},
                new Place() {Id = 6, Row = 1, Number = 5, IsReserved = false},
                new Place() {Id = 7, Row = 1, Number = 6, IsReserved = false},
                new Place() {Id = 8, Row = 1, Number = 7, IsReserved = false},
                new Place() {Id = 9, Row = 2, Number = 1, IsReserved = false},
                new Place() {Id = 10, Row = 2, Number = 1, IsReserved = false},
                new Place() {Id = 11, Row = 2, Number = 2, IsReserved = false},
                new Place() {Id = 12, Row = 2, Number = 3, IsReserved = false},
                new Place() {Id = 13, Row = 2, Number = 4, IsReserved = false},
                new Place() {Id = 14, Row = 2, Number = 5, IsReserved = false},
                new Place() {Id = 15, Row = 2, Number = 6, IsReserved = false},
                new Place() {Id = 16, Row = 2, Number = 7, IsReserved = false},
                new Place() {Id = 17, Row = 3, Number = 1, IsReserved = false},
                new Place() {Id = 18, Row = 3, Number = 2, IsReserved = false},
                new Place() {Id = 19, Row = 3, Number = 3, IsReserved = false},
                new Place() {Id = 20, Row = 3, Number = 4, IsReserved = false},
                new Place() {Id = 21, Row = 3, Number = 5, IsReserved = false},
                new Place() {Id = 22, Row = 3, Number = 6, IsReserved = false},
                new Place() {Id = 23, Row = 3, Number = 7, IsReserved = false},
                new Place() {Id = 24, Row = 4, Number = 1, IsReserved = false},
                new Place() {Id = 25, Row = 4, Number = 2, IsReserved = false},
                new Place() {Id = 26, Row = 4, Number = 3, IsReserved = false},
                new Place() {Id = 27, Row = 4, Number = 4, IsReserved = false},
                new Place() {Id = 28, Row = 4, Number = 5, IsReserved = false},
                new Place() {Id = 29, Row = 4, Number = 6, IsReserved = false},
                new Place() {Id = 30, Row = 4, Number = 7, IsReserved = false},
                new Place() {Id = 31, Row = 5, Number = 1, IsReserved = false},
                new Place() {Id = 32, Row = 5, Number = 2, IsReserved = false},
                new Place() {Id = 33, Row = 5, Number = 3, IsReserved = false},
                new Place() {Id = 34, Row = 5, Number = 4, IsReserved = false},
                new Place() {Id = 35, Row = 5, Number = 5, IsReserved = false},
                new Place() {Id = 36, Row = 5, Number = 6, IsReserved = false},
                new Place() {Id = 37, Row = 5, Number = 7, IsReserved = false},
            }
                },
                new DateTimePlace()
                {
                    dateTime = new DateTime(2019, 04, 17, 13, 0, 0, 0),
                    places = new List<Place>()
                    { new Place() {Id = 1, Row = 1, Number = 1, IsReserved = false},
                new Place() {Id = 2, Row = 1, Number = 1, IsReserved = false},
                new Place() {Id = 3, Row = 1, Number = 2, IsReserved = false},
                new Place() {Id = 4, Row = 1, Number = 3, IsReserved = false},
                new Place() {Id = 5, Row = 1, Number = 4, IsReserved = false},
                new Place() {Id = 6, Row = 1, Number = 5, IsReserved = false},
                new Place() {Id = 7, Row = 1, Number = 6, IsReserved = false},
                new Place() {Id = 8, Row = 1, Number = 7, IsReserved = false},
                new Place() {Id = 9, Row = 2, Number = 1, IsReserved = false},
                new Place() {Id = 10, Row = 2, Number = 1, IsReserved = false},
                new Place() {Id = 11, Row = 2, Number = 2, IsReserved = false},
                new Place() {Id = 12, Row = 2, Number = 3, IsReserved = false},
                new Place() {Id = 13, Row = 2, Number = 4, IsReserved = false},
                new Place() {Id = 14, Row = 2, Number = 5, IsReserved = false},
                new Place() {Id = 15, Row = 2, Number = 6, IsReserved = false},
                new Place() {Id = 16, Row = 2, Number = 7, IsReserved = false},
                new Place() {Id = 17, Row = 3, Number = 1, IsReserved = false},
                new Place() {Id = 18, Row = 3, Number = 2, IsReserved = false},
                new Place() {Id = 19, Row = 3, Number = 3, IsReserved = false},
                new Place() {Id = 20, Row = 3, Number = 4, IsReserved = false},
                new Place() {Id = 21, Row = 3, Number = 5, IsReserved = false},
                new Place() {Id = 22, Row = 3, Number = 6, IsReserved = false},
                new Place() {Id = 23, Row = 3, Number = 7, IsReserved = false},
                new Place() {Id = 24, Row = 4, Number = 1, IsReserved = false},
                new Place() {Id = 25, Row = 4, Number = 2, IsReserved = false},
                new Place() {Id = 26, Row = 4, Number = 3, IsReserved = false},
                new Place() {Id = 27, Row = 4, Number = 4, IsReserved = false},
                new Place() {Id = 28, Row = 4, Number = 5, IsReserved = false},
                new Place() {Id = 29, Row = 4, Number = 6, IsReserved = false},
                new Place() {Id = 30, Row = 4, Number = 7, IsReserved = false},
                new Place() {Id = 31, Row = 5, Number = 1, IsReserved = false},
                new Place() {Id = 32, Row = 5, Number = 2, IsReserved = false},
                new Place() {Id = 33, Row = 5, Number = 3, IsReserved = false},
                new Place() {Id = 34, Row = 5, Number = 4, IsReserved = false},
                new Place() {Id = 35, Row = 5, Number = 5, IsReserved = false},
                new Place() {Id = 36, Row = 5, Number = 6, IsReserved = false},
                new Place() {Id = 37, Row = 5, Number = 7, IsReserved = false},
            }
                },
                new DateTimePlace()
                {
                    dateTime = new DateTime(2019, 04, 17, 15, 0, 0, 0),
                    places = new List<Place>()
                    {new Place() {Id = 1, Row = 1, Number = 1, IsReserved = false},
                new Place() {Id = 2, Row = 1, Number = 1, IsReserved = false},
                new Place() {Id = 3, Row = 1, Number = 2, IsReserved = false},
                new Place() {Id = 4, Row = 1, Number = 3, IsReserved = false},
                new Place() {Id = 5, Row = 1, Number = 4, IsReserved = false},
                new Place() {Id = 6, Row = 1, Number = 5, IsReserved = false},
                new Place() {Id = 7, Row = 1, Number = 6, IsReserved = false},
                new Place() {Id = 8, Row = 1, Number = 7, IsReserved = false},
                new Place() {Id = 9, Row = 2, Number = 1, IsReserved = false},
                new Place() {Id = 10, Row = 2, Number = 1, IsReserved = false},
                new Place() {Id = 11, Row = 2, Number = 2, IsReserved = false},
                new Place() {Id = 12, Row = 2, Number = 3, IsReserved = false},
                new Place() {Id = 13, Row = 2, Number = 4, IsReserved = false},
                new Place() {Id = 14, Row = 2, Number = 5, IsReserved = false},
                new Place() {Id = 15, Row = 2, Number = 6, IsReserved = false},
                new Place() {Id = 16, Row = 2, Number = 7, IsReserved = false},
                new Place() {Id = 17, Row = 3, Number = 1, IsReserved = false},
                new Place() {Id = 18, Row = 3, Number = 2, IsReserved = false},
                new Place() {Id = 19, Row = 3, Number = 3, IsReserved = false},
                new Place() {Id = 20, Row = 3, Number = 4, IsReserved = false},
                new Place() {Id = 21, Row = 3, Number = 5, IsReserved = false},
                new Place() {Id = 22, Row = 3, Number = 6, IsReserved = false},
                new Place() {Id = 23, Row = 3, Number = 7, IsReserved = false},
                new Place() {Id = 24, Row = 4, Number = 1, IsReserved = false},
                new Place() {Id = 25, Row = 4, Number = 2, IsReserved = false},
                new Place() {Id = 26, Row = 4, Number = 3, IsReserved = false},
                new Place() {Id = 27, Row = 4, Number = 4, IsReserved = false},
                new Place() {Id = 28, Row = 4, Number = 5, IsReserved = false},
                new Place() {Id = 29, Row = 4, Number = 6, IsReserved = false},
                new Place() {Id = 30, Row = 4, Number = 7, IsReserved = false},
                new Place() {Id = 31, Row = 5, Number = 1, IsReserved = false},
                new Place() {Id = 32, Row = 5, Number = 2, IsReserved = false},
                new Place() {Id = 33, Row = 5, Number = 3, IsReserved = false},
                new Place() {Id = 34, Row = 5, Number = 4, IsReserved = false},
                new Place() {Id = 35, Row = 5, Number = 5, IsReserved = false},
                new Place() {Id = 36, Row = 5, Number = 6, IsReserved = false},
                new Place() {Id = 37, Row = 5, Number = 7, IsReserved = false},
            }
                },
                new DateTimePlace()
                {
                    dateTime = new DateTime(2019, 04, 17, 15, 0, 0, 0),
                    places = new List<Place>()
                    { new Place() {Id = 1, Row = 1, Number = 1, IsReserved = false},
                new Place() {Id = 2, Row = 1, Number = 1, IsReserved = false},
                new Place() {Id = 3, Row = 1, Number = 2, IsReserved = false},
                new Place() {Id = 4, Row = 1, Number = 3, IsReserved = false},
                new Place() {Id = 5, Row = 1, Number = 4, IsReserved = false},
                new Place() {Id = 6, Row = 1, Number = 5, IsReserved = false},
                new Place() {Id = 7, Row = 1, Number = 6, IsReserved = false},
                new Place() {Id = 8, Row = 1, Number = 7, IsReserved = false},
                new Place() {Id = 9, Row = 2, Number = 1, IsReserved = false},
                new Place() {Id = 10, Row = 2, Number = 1, IsReserved = false},
                new Place() {Id = 11, Row = 2, Number = 2, IsReserved = false},
                new Place() {Id = 12, Row = 2, Number = 3, IsReserved = false},
                new Place() {Id = 13, Row = 2, Number = 4, IsReserved = false},
                new Place() {Id = 14, Row = 2, Number = 5, IsReserved = false},
                new Place() {Id = 15, Row = 2, Number = 6, IsReserved = false},
                new Place() {Id = 16, Row = 2, Number = 7, IsReserved = false},
                new Place() {Id = 17, Row = 3, Number = 1, IsReserved = false},
                new Place() {Id = 18, Row = 3, Number = 2, IsReserved = false},
                new Place() {Id = 19, Row = 3, Number = 3, IsReserved = false},
                new Place() {Id = 20, Row = 3, Number = 4, IsReserved = false},
                new Place() {Id = 21, Row = 3, Number = 5, IsReserved = false},
                new Place() {Id = 22, Row = 3, Number = 6, IsReserved = false},
                new Place() {Id = 23, Row = 3, Number = 7, IsReserved = false},
                new Place() {Id = 24, Row = 4, Number = 1, IsReserved = false},
                new Place() {Id = 25, Row = 4, Number = 2, IsReserved = false},
                new Place() {Id = 26, Row = 4, Number = 3, IsReserved = false},
                new Place() {Id = 27, Row = 4, Number = 4, IsReserved = false},
                new Place() {Id = 28, Row = 4, Number = 5, IsReserved = false},
                new Place() {Id = 29, Row = 4, Number = 6, IsReserved = false},
                new Place() {Id = 30, Row = 4, Number = 7, IsReserved = false},
                new Place() {Id = 31, Row = 5, Number = 1, IsReserved = false},
                new Place() {Id = 32, Row = 5, Number = 2, IsReserved = false},
                new Place() {Id = 33, Row = 5, Number = 3, IsReserved = false},
                new Place() {Id = 34, Row = 5, Number = 4, IsReserved = false},
                new Place() {Id = 35, Row = 5, Number = 5, IsReserved = false},
                new Place() {Id = 36, Row = 5, Number = 6, IsReserved = false},
                new Place() {Id = 37, Row = 5, Number = 7, IsReserved = false},
            }
                },
                new DateTimePlace()
                {
                    dateTime = new DateTime(2019, 04, 17, 19, 0, 0, 0),
                    places = new List<Place>()
                    { new Place() {Id = 1, Row = 1, Number = 1, IsReserved = false},
                new Place() {Id = 2, Row = 1, Number = 1, IsReserved = false},
                new Place() {Id = 3, Row = 1, Number = 2, IsReserved = false},
                new Place() {Id = 4, Row = 1, Number = 3, IsReserved = false},
                new Place() {Id = 5, Row = 1, Number = 4, IsReserved = false},
                new Place() {Id = 6, Row = 1, Number = 5, IsReserved = false},
                new Place() {Id = 7, Row = 1, Number = 6, IsReserved = false},
                new Place() {Id = 8, Row = 1, Number = 7, IsReserved = false},
                new Place() {Id = 9, Row = 2, Number = 1, IsReserved = false},
                new Place() {Id = 10, Row = 2, Number = 1, IsReserved = false},
                new Place() {Id = 11, Row = 2, Number = 2, IsReserved = false},
                new Place() {Id = 12, Row = 2, Number = 3, IsReserved = false},
                new Place() {Id = 13, Row = 2, Number = 4, IsReserved = false},
                new Place() {Id = 14, Row = 2, Number = 5, IsReserved = false},
                new Place() {Id = 15, Row = 2, Number = 6, IsReserved = false},
                new Place() {Id = 16, Row = 2, Number = 7, IsReserved = false},
                new Place() {Id = 17, Row = 3, Number = 1, IsReserved = false},
                new Place() {Id = 18, Row = 3, Number = 2, IsReserved = false},
                new Place() {Id = 19, Row = 3, Number = 3, IsReserved = false},
                new Place() {Id = 20, Row = 3, Number = 4, IsReserved = false},
                new Place() {Id = 21, Row = 3, Number = 5, IsReserved = false},
                new Place() {Id = 22, Row = 3, Number = 6, IsReserved = false},
                new Place() {Id = 23, Row = 3, Number = 7, IsReserved = false},
                new Place() {Id = 24, Row = 4, Number = 1, IsReserved = false},
                new Place() {Id = 25, Row = 4, Number = 2, IsReserved = false},
                new Place() {Id = 26, Row = 4, Number = 3, IsReserved = false},
                new Place() {Id = 27, Row = 4, Number = 4, IsReserved = false},
                new Place() {Id = 28, Row = 4, Number = 5, IsReserved = false},
                new Place() {Id = 29, Row = 4, Number = 6, IsReserved = false},
                new Place() {Id = 30, Row = 4, Number = 7, IsReserved = false},
                new Place() {Id = 31, Row = 5, Number = 1, IsReserved = false},
                new Place() {Id = 32, Row = 5, Number = 2, IsReserved = false},
                new Place() {Id = 33, Row = 5, Number = 3, IsReserved = false},
                new Place() {Id = 34, Row = 5, Number = 4, IsReserved = false},
                new Place() {Id = 35, Row = 5, Number = 5, IsReserved = false},
                new Place() {Id = 36, Row = 5, Number = 6, IsReserved = false},
                new Place() {Id = 37, Row = 5, Number = 7, IsReserved = false},
            }
                },
            };
        }
    }
}



