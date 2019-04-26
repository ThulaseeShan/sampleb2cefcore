using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace authb2cweb.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Venue { get; set; }
        public string CreatedBy { get; set; }

        [NotMapped]
        public int NumberOfAttendees { get; set; }

        public List<Attendee> Attendees { get; set; }
    }
}
