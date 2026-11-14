using Infrastructure.Database.OriginEntity;

namespace Infrastructure.Database.RobotsPermissionEntity;

/*
 *
 * Should we have a separate 
 * 
 */

public class RobotsPermission
{
    public long RecordNumber { get; set; }
    public Origin Origin { get; set; } = null!;
    public long OriginId { get; set; }
    public string Path { get; set; } = null!;
    public bool Allow { get; set; }
}