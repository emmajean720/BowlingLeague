namespace BowlingLeague.Data
{
    public class Team
    {
        public int TeamID { get; set; } // NOT NULL DEFAULT 0 in DB
        public string TeamName { get; set; } // NOT NULL in DB (required)
        public int? CaptainID { get; set; } // Nullable in DB (no NOT NULL)
                                            // Navigation Property (Optional: One-to-Many)
        public ICollection<Bowler>? Bowlers { get; set; }
    }
}
