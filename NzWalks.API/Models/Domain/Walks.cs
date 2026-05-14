namespace NzWalks.API.Models.Domain
{
    public class Walks
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public double LengthInKm { get; set; }
        public string? WalkImageUrl { get; set; }

        // Foreign Key
        public Guid RegionId { get; set; }
        public Regions Region { get; set; }

        // Foreign Key
        public Guid DifficultyId { get; set; }
        public Difficulties Difficulty { get; set; }
    }
}
