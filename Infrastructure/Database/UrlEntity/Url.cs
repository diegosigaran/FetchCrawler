using Infrastructure.Database.OriginEntity;

namespace Infrastructure.Database.UrlEntity;

/// <summary>
/// Represents an individual discovered URL
/// </summary>
public class Url
{
    public long RecordNumber { get; set; }
    public Origin Origin { get; set; } = null!;
    public long OriginId { get; set; }
    public string UrlString { get; set; } = null!;
    public DateTimeOffset DiscoveredAt { get; set; }
    public DateTimeOffset? LastFetchedAt { get; set; }
    public DateTimeOffset? NextFetchAt { get; set; }
}