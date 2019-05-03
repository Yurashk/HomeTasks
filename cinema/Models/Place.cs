using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace cinema.Models
{
    public class Place
    {
        public int Id { get; set; }
        public int Row { get; set; }
        public int Number { get; set; }
        public bool IsReserved { get; set; }
    }
}
