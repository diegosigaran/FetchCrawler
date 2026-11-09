namespace Infrastructure.Database.CrawlRunEntity;

/// <summary>
/// Represents the individual execution of a crawl job.
///
/// Separates the definition of a recurring crawl job from each individual execution.
///
/// For example, one job could run every 24 hours. Each execution would have it's own crawl run: start time, completition time, and outcome. 
/// 
/// </summary>
public class CrawlRun
{
    
}