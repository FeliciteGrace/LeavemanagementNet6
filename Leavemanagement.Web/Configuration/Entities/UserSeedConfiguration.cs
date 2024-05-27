using Leavemanagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Leavemanagement.Web.Configuration.Entities
{
    internal class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "2baba142-4dc3-464f-bac7-b98f7190a173",
                    Email = "admin@test.com",
                    NormalizedEmail = "ADMIN@TEST.COM",
                    NormalizedUserName = "ADMIN@TEST.COM",
                    UserName = "admin@test.com",
                    Firstname = "System",
                    Lastname = "Admin",
                    PasswordHash = hasher.HashPassword(null, "Password@1"),
                    EmailConfirmed = true,
                },
                 new Employee
                 {
                     Id = "d35b8cbe-4baa-4ee2-a270-297532cd11e1",
                     Email = "user@test.com",
                     NormalizedEmail = "USER@TEST.COM",
                     NormalizedUserName = "USER@TEST.COM",
                     UserName = "user@test.com",
                     Firstname = "System",
                     Lastname = "User",
                     PasswordHash = hasher.HashPassword(null, "Password@1"),
                     EmailConfirmed = true,
                 }
            );
        }
    }
}