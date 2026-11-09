using Common.Enums;

namespace Infrastructure.Database.PolicyEntity;

/// <summary>
/// Stores configured crawl restrictions and permissions. 
/// </summary>
public class Policy
{
    public int RecordNumber { get; set; }
    public ApprovalStatus Status { get; set; }
}