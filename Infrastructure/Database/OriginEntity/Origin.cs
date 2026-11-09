namespace Infrastructure.Database.OriginEntity;

public class Origin
{
    public int RecordNumber { get; set; }
    public required string OriginUrl { get; set; } = null!;
    public DateTimeOffset FirstDiscoveredAt { get; set; }
    public DateTimeOffset FirstVisitedAt { get; set; }
    public DateTimeOffset? LastVisitedAt { get; set; }
    public DateTimeOffset LastRobotsCheckedAt { get; set; }
    public DateTimeOffset NextEligibleVisitAt { get; set; }
}