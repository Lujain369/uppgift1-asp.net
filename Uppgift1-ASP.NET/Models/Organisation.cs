﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uppgift1_asp.net.Models
{
    public class Organisation
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public List<Event> events { get; set; }
    }
}
