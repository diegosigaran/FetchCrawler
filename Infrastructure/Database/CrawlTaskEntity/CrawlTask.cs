using Common.Enums;
using Infrastructure.Database.CrawlJobEntity;
using Infrastructure.Database.UrlEntity;

namespace Infrastructure.Database.CrawlTaskEntity;

/// <summary>
/// Represents a scheduled unit of work for a URL
/// </summary>
public class CrawlTask
{
    public long Id { get; set; }
    public CrawlJob Job { get; set; }
    public long CrawlJobId { get; set; }
    public Url Url { get; set; }
    public long UrlId { get; set; }
    public CrawlTaskStatus Status { get; set; }
    public int Priority { get; set; }
    public int AttemptCount { get; set; }
    public DateTimeOffset ScheduledAt { get; set; }
    public DateTimeOffset? LeaseExpiresAt { get; set; }
}