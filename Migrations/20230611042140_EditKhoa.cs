using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_Demo.Migrations
{
    /// <inheritdoc />
    public partial class EditKhoa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Filter",
                table: "KHOA",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "KHOA",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        //protected override void Down(MigrationBuilder migrationBuilder)
        //{
        //    migrationBuilder.DropColumn(
        //        name: "Filter",
        //        table: "KHOA");

        //    migrationBuilder.DropColumn(
        //        name: "IsActive",
        //        table: "KHOA");
        //}
    }
}
