using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leavemanagement.Web.Data.Migrations
{
    public partial class addeddefaultusersandroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2cfea142-4ab3-784f-baa7-b98f4190a903", "f633fcb6-ebec-4be1-b794-d2d132f662f3", "Administrator", "ADMINISTRATOR" },
                    { "2jeea142-4ea3-437f-bce7-b97e3290a213", "359b5205-4149-4341-9fc0-3e1f1d9e0a7f", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2baba142-4dc3-464f-bac7-b98f7190a173", 0, "ac461cd1-41bd-45e6-a53f-e38ee872809c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@test.com", false, "System", "Admin", false, null, "ADMIN@TEST.COM", null, "AQAAAAEAACcQAAAAEKD3dnNhTshr1x5CxAGYjgS/XipTqibTrwgiTTyEWSiDfFgDjjE9t/U4X1vcBQiyPw==", null, false, "c87ad8e2-7341-4a5b-a8a3-5bcfe092ff15", null, false, null },
                    { "d35b8cbe-4baa-4ee2-a270-297532cd11e1", 0, "eb865f19-d3bd-4c38-bbeb-cfa3b1083c6b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@test.com", false, "System", "User", false, null, "USER@TEST.COM", null, "AQAAAAEAACcQAAAAEBgmCFkjj7Lsd4JMjLuF8foXVhxzdq30bEFjRCxherFMha+UgZRQH9fnkjtvW7n7xw==", null, false, "ccced186-2943-4863-93af-4f4fbb8bbf1f", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2cfea142-4ab3-784f-baa7-b98f4190a903", "2baba142-4dc3-464f-bac7-b98f7190a173" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2jeea142-4ea3-437f-bce7-b97e3290a213", "d35b8cbe-4baa-4ee2-a270-297532cd11e1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2cfea142-4ab3-784f-baa7-b98f4190a903", "2baba142-4dc3-464f-bac7-b98f7190a173" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2jeea142-4ea3-437f-bce7-b97e3290a213", "d35b8cbe-4baa-4ee2-a270-297532cd11e1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2cfea142-4ab3-784f-baa7-b98f4190a903");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2jeea142-4ea3-437f-bce7-b97e3290a213");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2baba142-4dc3-464f-bac7-b98f7190a173");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d35b8cbe-4baa-4ee2-a270-297532cd11e1");
        }
    }
}
