using Infrastructure.Database.OriginEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Database.RobotsPermissionEntity;

public class RobotPermissionConfiguration : IEntityTypeConfiguration<RobotsPermission> 
{

    public void Configure(EntityTypeBuilder<RobotsPermission> entityBuilder)
    {
        
        entityBuilder.HasKey(x => x.RecordNumber);

        entityBuilder.Property(x => x.RecordNumber).UseIdentityByDefaultColumn();

        entityBuilder.Property(x => x.Origin).HasColumnType("text");

        entityBuilder
            .HasOne(permission => permission.Origin)
            .WithMany()
            .HasForeignKey(permission => permission.OriginId);

    }
    
}