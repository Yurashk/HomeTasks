using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cinema.Models
{
    public class TransferModel
    {
        public int FilmId { get; set; }
        public string Date { get; set; }
        public  int PlaceId { get; set; }
    }
}
