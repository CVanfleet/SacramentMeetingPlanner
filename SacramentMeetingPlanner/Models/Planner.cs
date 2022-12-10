using System.ComponentModel.DataAnnotations;

namespace SacramentMeetingPlanner.Models
{
    public class Planner
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s]*$")]
        [StringLength(80, MinimumLength = 7)]
        [Required]
        public string Leader { get; set; }

        [Display(Name = "Opening Song")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9,""'\s-#]*$")]
        [StringLength(80, MinimumLength = 7)]
        [Required]
        public string OpeningSong { get; set; }

        [Display(Name = "Sacrament Hymn")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9,""'\s-#]*$")]
        [StringLength(80, MinimumLength = 7)]
        [Required]
        public string SacramentHymn { get; set; }

        [Display(Name = "Closing Song")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9,""'\s-#]*$")]
        [StringLength(80, MinimumLength = 7)]
        [Required]
        public string ClosingSong { get; set; }

        [Display(Name = "Musical Number")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9,""'\s-#]*$")]
        public string? MusicalNumber { get; set; }

        [Display(Name = "Opening Prayer")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s]*$")]
        [StringLength(80, MinimumLength = 7)]
        [Required]
        public string OpeningPrayer { get; set; }

        [Display(Name = "Closing Prayer")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s]*$")]
        [StringLength(80, MinimumLength = 7)]
        [Required]
        public string ClosingPrayer { get; set; }

        [Display(Name = "Speaker 1")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s]*$")]
        [StringLength(80, MinimumLength = 7)]
        public string Speaker1 { get; set; }

        [Display(Name = "Speaker 2")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s]*$")]
        [StringLength(80, MinimumLength = 7)]
        public string? Speaker2 { get; set; }

        [Display(Name = "Speaker 3")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s]*$")]
        [StringLength(80, MinimumLength = 7)]
        public string? Speaker3 { get; set; }

        [Display(Name = "Speaker 4")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s]*$")]
        [StringLength(80, MinimumLength = 7)]
        public string? Speaker4 { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s]*$")]
        [StringLength(80, MinimumLength = 7)]
        public string Subject { get; set; }


    }
}
