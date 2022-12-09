using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Data;

namespace SacramentMeetingPlanner.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SacramentMeetingPlannerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SacramentMeetingPlannerContext>>()))
            {
                if (context == null || context.Planner == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.Planner.Any())
                {
                    return;   // DB has been seeded
                }

                context.Planner.AddRange(
                    new Planner
                    {
                        Date = DateTime.Parse("2022-12-11"),
                        Leader = "Bishop Brown", 
                        OpeningSong = "High on the Mountain Top",
                        SacramentHymn = "As Now We Take the Sacrament",
                        ClosingSong = "Abide with Me!",
                        MusicalNumber = "Come Thou Fount",
                        OpeningPrayer = "Clayton Vanfleet",
                        ClosingPrayer = "Amanda Vanfleet",
                        Speaker1 = "Samantha Smith",
                        Speaker2 = "Bob Smith",
                        Subject = "Atonement"
                    },

                    new Planner
                    {
                        Date = DateTime.Parse("2022-12-18"),
                        Leader = "Bishop Brown",
                        OpeningSong = "I Know That My Redeemer Lives",
                        SacramentHymn = "Thy Will, O Lord, Be Done",
                        ClosingSong = "Teach Me to Walk in the Light",
                        OpeningPrayer = "Raphael Gomez",
                        ClosingPrayer = "Kristina Matthews",
                        Speaker1 = "Bobby Anderson",
                        Speaker2 = "Hudson Beardall",
                        Speaker3 = "Clayton Ith",
                        Subject = "Book Of Mormon"
                    },

                    new Planner
                    {
                        Date = DateTime.Parse("2022-12-25"),
                        Leader = "President Jones",
                        OpeningSong = "Hark! The Herald Angels Sing",
                        SacramentHymn = "Silent Night",
                        ClosingSong = "I Heard the Bells on Christmas Day",
                        MusicalNumber = "Angels We Have Heard on High",
                        OpeningPrayer = "Charles Kriston",
                        ClosingPrayer = "Trent Ith",
                        Speaker1 = "Bishop Brown",
                        Speaker2 = "President Jones",
                        Subject = "Christmas"
                    },

                    new Planner
                    {
                        Date = DateTime.Parse("2023-1-1"),
                        Leader = "Bishop Brown",
                        OpeningSong = "Nearer, My God, to Thee",
                        SacramentHymn = "With Humble Heart",
                        ClosingSong = "Come Unto Jesus",
                        OpeningPrayer = "Amanda Rianne",
                        ClosingPrayer = "Hudson Vanfleet",
                        Speaker1 = "Howard Robbins",
                        Speaker2 = "Shellie Haake",
                        Speaker3 = "Helen Barker",
                        Subject = "Prayer"
                    } 
                );
                context.SaveChanges();
            }
        }
    }
}