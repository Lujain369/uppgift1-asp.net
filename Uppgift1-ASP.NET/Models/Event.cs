using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace uppgift1_asp.net.Models
{
    public class Event
    {
        public int event_id { get; set; }
        public string title { get; set; }
        public int organisation_id { get; set; }
        public string description { get; set; }
        public string place { get; set; }
        public string adress { get; set; }
        public DateTime date { get; set; }
        public int spots_available { get; set; }
    }
}
