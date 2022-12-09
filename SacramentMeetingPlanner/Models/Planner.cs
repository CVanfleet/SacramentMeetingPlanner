using System.ComponentModel.DataAnnotations;

namespace SacramentMeetingPlanner.Models
{
    public class Planner
    {
        public int ID { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Leader { get; set; }
        public string OpeningSong { get; set; }
        public string SacramentHymn { get; set; }
        public string ClosingSong { get; set; }
        public string? MusicalNumber { get; set; }
        public string OpeningPrayer { get; set; }
        public string ClosingPrayer { get; set; }
        public string Speaker1 { get; set; }
        public string? Speaker2 { get; set; }

        public string? Speaker3 { get; set; }

        public string? Speaker4 { get; set; }

        public string Subject { get; set; }


    }
}
