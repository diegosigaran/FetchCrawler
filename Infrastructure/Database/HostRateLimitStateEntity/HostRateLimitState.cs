namespace Infrastructure.Database.HostRateLimitStateEntity;

/// <summary>
/// Coordinates request throttling across workers.
///
/// Multiple workers must not independently assume they can fetch from the same host.
///
/// The state could be stored in postgresql or another shared coordination system.
/// 
/// </summary>
public class HostRateLimitState
{
    
    
    
}