using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uppgift1_asp.net.Models;

namespace uppgift1_asp.net.Data
{
    public class EventsDbContext : DbContext
    {
        public EventsDbContext(DbContextOptions<EventsDbContext> options)
         : base(options)

        {
        }

        public DbSet<Event> Event { get; set; }
        public DbSet<Attender> Attender { get; set; }
        public DbSet<Organisation> Organisation { get; set; }

        public void seed()
        {
            Attender.RemoveRange(Attender);
            Event.RemoveRange(Event);
            
            Attender Lolo = new Attender { name = "Lolo", email = "antonberglund@hotmail.com", phone_number = "0731337123" };
            Attender.Add(Lolo);

            Event.AddRange(new List<Event>()
            {
                 new Event(){ title="Bollspel", date=DateTime.Now, adress="Norrköping", spots_available=400},
                 new Event(){ title="Coronafest", date=DateTime.Now, adress="Kungsbacka", spots_available=400},
                 new Event(){ title="Fotboll", date=DateTime.Now, adress="Göteborg", spots_available=400},
                 new Event(){ title="Vintest", date=DateTime.Now, adress="Mölndal", spots_available=400},

            });

            SaveChanges();
        } 
    }
}

