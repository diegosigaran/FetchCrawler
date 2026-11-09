using Common.Enums;

namespace Infrastructure.Database.PolicyEntity;

public class Policy
{
    public int RecordNumber { get; set; }
    public ApprovalStatus Status { get; set; }
}