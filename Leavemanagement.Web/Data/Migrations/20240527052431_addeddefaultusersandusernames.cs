using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leavemanagement.Web.Data.Migrations
{
    public partial class addeddefaultusersandusernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2cfea142-4ab3-784f-baa7-b98f4190a903",
                column: "ConcurrencyStamp",
                value: "4d0c5242-c227-45e6-b6cb-07e66303649f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2jeea142-4ea3-437f-bce7-b97e3290a213",
                column: "ConcurrencyStamp",
                value: "7d050e74-bfbf-44da-9a78-d58f691bc60a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2baba142-4dc3-464f-bac7-b98f7190a173",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8c44041b-6582-41eb-926d-123bf70dbfe7", true, "ADMIN@TEST.COM", "AQAAAAEAACcQAAAAEMzjw72rj42AH/+YoaicXp470SPO3Htgh1GUGBdPQv2O+zBXwraXyfuUIFEbGKcCLA==", "59ea0f2e-d645-46f7-91d7-7eb6cb5c69fe", "admin@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d35b8cbe-4baa-4ee2-a270-297532cd11e1",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bee0be0b-5c6e-4eaf-b9e0-470dd25c019e", true, "USER@TEST.COM", "AQAAAAEAACcQAAAAEJFmamCYVaw5ij+w2aNB2SNV7SWD4S2iXhUAUf/pfBws0XpDi28dd/LyETXLeO7LOw==", "a8db3b2e-6942-45a8-949c-16a117812ce1", "user@test.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2cfea142-4ab3-784f-baa7-b98f4190a903",
                column: "ConcurrencyStamp",
                value: "f633fcb6-ebec-4be1-b794-d2d132f662f3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2jeea142-4ea3-437f-bce7-b97e3290a213",
                column: "ConcurrencyStamp",
                value: "359b5205-4149-4341-9fc0-3e1f1d9e0a7f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2baba142-4dc3-464f-bac7-b98f7190a173",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ac461cd1-41bd-45e6-a53f-e38ee872809c", false, null, "AQAAAAEAACcQAAAAEKD3dnNhTshr1x5CxAGYjgS/XipTqibTrwgiTTyEWSiDfFgDjjE9t/U4X1vcBQiyPw==", "c87ad8e2-7341-4a5b-a8a3-5bcfe092ff15", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d35b8cbe-4baa-4ee2-a270-297532cd11e1",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "eb865f19-d3bd-4c38-bbeb-cfa3b1083c6b", false, null, "AQAAAAEAACcQAAAAEBgmCFkjj7Lsd4JMjLuF8foXVhxzdq30bEFjRCxherFMha+UgZRQH9fnkjtvW7n7xw==", "ccced186-2943-4863-93af-4f4fbb8bbf1f", null });
        }
    }
}
