using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfrastructureLayer.Configurations
{
    public class BlockedUserConfiguration : IEntityTypeConfiguration<BlockedUser>
    {
        public void Configure(EntityTypeBuilder<BlockedUser> builder)
        {
            builder.ToTable("BlockedUsers");

            builder.HasKey(bu => bu.Id);

            builder.HasOne(bu => bu.User)
                .WithMany(u => u.BlockedUsers)
                .HasForeignKey(bu => bu.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(bu => bu.UserToBlock);


        }
    }
}
