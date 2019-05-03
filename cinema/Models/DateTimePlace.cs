using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cinema.Models
{
    public class DateTimePlace
    {
        public DateTime dateTime { get; set; }
        public List<Place> places { get; set; }
    }
}
