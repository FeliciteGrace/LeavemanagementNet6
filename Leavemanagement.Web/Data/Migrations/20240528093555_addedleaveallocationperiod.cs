using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leavemanagement.Web.Data.Migrations
{
    public partial class addedleaveallocationperiod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2cfea142-4ab3-784f-baa7-b98f4190a903",
                column: "ConcurrencyStamp",
                value: "5ed1b758-b7c6-4402-a8ca-9967356311ae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2jeea142-4ea3-437f-bce7-b97e3290a213",
                column: "ConcurrencyStamp",
                value: "d532fb98-a6e5-4535-b148-9dec98ee9223");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2baba142-4dc3-464f-bac7-b98f7190a173",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7af8452-e5d2-4320-86e0-a8fe9c27b1ec", "AQAAAAEAACcQAAAAELHWYYCroROvHKIOXWCtQTwL2F16x8p/0tqpOjhBPCo16Ndx6AcLsjZnv0SEU+XT7A==", "358ed852-cf87-4948-a40b-d50aebbfd68d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d35b8cbe-4baa-4ee2-a270-297532cd11e1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0e5e552-4595-45c3-a399-efca9f2b4f06", "AQAAAAEAACcQAAAAEMBq0bUxMddNZu1X7/aHm5Xe7CvXvhuUgylCqw872T6cFfaQyOhWLewfhlRPtyg+yQ==", "4d583abf-cc2d-4daa-8e4f-7179c0445276" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c44041b-6582-41eb-926d-123bf70dbfe7", "AQAAAAEAACcQAAAAEMzjw72rj42AH/+YoaicXp470SPO3Htgh1GUGBdPQv2O+zBXwraXyfuUIFEbGKcCLA==", "59ea0f2e-d645-46f7-91d7-7eb6cb5c69fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d35b8cbe-4baa-4ee2-a270-297532cd11e1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bee0be0b-5c6e-4eaf-b9e0-470dd25c019e", "AQAAAAEAACcQAAAAEJFmamCYVaw5ij+w2aNB2SNV7SWD4S2iXhUAUf/pfBws0XpDi28dd/LyETXLeO7LOw==", "a8db3b2e-6942-45a8-949c-16a117812ce1" });
        }
    }
}
