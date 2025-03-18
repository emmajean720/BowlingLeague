using Microsoft.EntityFrameworkCore;

namespace BowlingLeague.Data
{
    public class BowlerRepository
    {
        private readonly BowlerDbContext _context;
        public BowlerRepository(BowlerDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Bowler> GetBowlersForMarlinsAndSharks()
        {
            return _context.Bowlers
                .Include(b => b.Team)
                .Where(b => b.Team!.TeamName == "Marlins" || b.Team!.TeamName == "Sharks")
                .Select(b => new Bowler // Project to a new object, excluding problematic fields
                {
                    BowlerID = b.BowlerID,
                    BowlerLastName = b.BowlerLastName,
                    BowlerFirstName = b.BowlerFirstName,
                    // Skip BowlerMiddleInit if it's causing issues
                    BowlerAddress = b.BowlerAddress,
                    BowlerCity = b.BowlerCity,
                    BowlerState = b.BowlerState,
                    BowlerZip = b.BowlerZip,
                    BowlerPhoneNumber = b.BowlerPhoneNumber,
                    TeamID = b.TeamID,
                    Team = b.Team
                })
                .ToList();
        }
    }
}
