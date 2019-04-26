using authb2cweb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace authb2cweb.Data
{
    public static class DBInitializer
    {
        public static void Initialize(EventContext context)
        {
            context.Database.EnsureCreated();

            if (context.Events.Any())
            {
                //Database already seeded
                return;
            }

            var events = new Event[]
            {
                new Event()
                {
                    Name ="London Event",
                    Venue ="London",
                    Date =DateTime.Today.AddMonths(1),
                    Attendees = new List<Attendee>()
                    {
                        new Attendee()
                        {
                            FirstName = "Peter",
                            LastName = "John",
                            Email = "pete@hotmail.com",
                            Phone="+44 203 882 7700"
                        },
                        new Attendee()
                        {
                            FirstName = "Andrew",
                            LastName = "James",
                            Email = "andrew_j@gmail.com",
                            Phone="+44 208 834 8737"
                        }
                    }
                },
                new Event()
                {
                    Name ="Seattle Event",
                    Venue ="Seattle",
                    Date =DateTime.Today.AddMonths(2),
                    Attendees = new List<Attendee>()
                    {
                        new Attendee()
                        {
                            FirstName = "Scott",
                            LastName = "Guthir",
                            Email = "scottg@microsoft.com",
                            Phone="+1 402 9397420"
                        },
                        new Attendee()
                        {
                            FirstName = "Sathya",
                            LastName = "Nadella",
                            Email = "satya@gmail.com",
                            Phone="+1 402 7379422"
                        },
                        new Attendee()
                        {
                            FirstName = "Darren",
                            LastName = "Evans",
                            Email = "darr@evans.com",
                            Phone="+1 838 4747493"
                        }
                    }
                }
            };
            foreach (var item in events)
            {
                context.Events.Add(item);
            }
            context.SaveChanges();
        }
    }
}
