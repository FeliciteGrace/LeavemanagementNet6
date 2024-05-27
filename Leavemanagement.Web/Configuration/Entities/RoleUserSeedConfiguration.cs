using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Leavemanagement.Web.Configuration.Entities
{
    internal class RoleUserSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {

            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2cfea142-4ab3-784f-baa7-b98f4190a903",
                    UserId = "2baba142-4dc3-464f-bac7-b98f7190a173"
                },
                 new IdentityUserRole<string>
                 {
                     RoleId = "2jeea142-4ea3-437f-bce7-b97e3290a213",
                     UserId = "d35b8cbe-4baa-4ee2-a270-297532cd11e1"
                 }
            );
        }
    }
}