﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cinema.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<DateTimePlace> DateTimePlaces{ get; set; }
    }
}
