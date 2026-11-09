namespace Common.Enums;

public enum CrawlAccessReason
{
    None = 0,

    // Robots.txt (100-199)
    RobotsPathDisallowed = 100,
    RobotsUnavailable = 101,
    RobotsRulesExpired = 102,

    // Security (200-299)
    PrivateIpAddress = 200,
    LoopbackAddress = 201,
    LinkLocalAddress = 202,
    UnsafeRedirect = 203,
    UnsupportedScheme = 204,
    InvalidUrl = 205,
    DnsResolutionBlocked = 206,

    // HTTP / Server (300-399)
    TooManyRequests = 300,
    ServiceUnavailable = 301,
    AuthenticationRequired = 302,
    AccessForbidden = 303,
    RepeatedTimeouts = 304,

    // Configuration (400-499)
    OutsideAllowedScope = 400,
    ManuallyBlocked = 401,
    HostNotApproved = 402,
    UnsupportedContentType = 403,

    // Operational (500-599)
    MaximumRetriesExceeded = 500,
    CircuitBreakerOpen = 501,
    ConcurrencyLimitReached = 502,

    // Permissions (600-699)
    OwnerOptOut = 600,
    PermissionReviewRequired = 601
}