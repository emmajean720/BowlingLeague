using System.Runtime.InteropServices;

namespace BowlingLeague.Data
{
    public class Bowler
    {
        public int BowlerID { get; set; }

        // All string properties are nullable (string?) to handle NULLs in the database
        public string? BowlerLastName { get; set; }
        public string? BowlerFirstName { get; set; }
        public string? BowlerMiddleInit { get; set; } // nvarchar(1) in DB
        public string? BowlerAddress { get; set; }
        public string? BowlerCity { get; set; }
        public string? BowlerState { get; set; } // nvarchar(2) in DB
        public string? BowlerZip { get; set; } // nvarchar(10) in DB
        public string? BowlerPhoneNumber { get; set; } // nvarchar(14) in DB

        // TeamID is NOT NULL DEFAULT 0 in DB
        public int TeamID { get; set; }

        // Navigation property to Team
        public Team? Team { get; set; }
    }
}
