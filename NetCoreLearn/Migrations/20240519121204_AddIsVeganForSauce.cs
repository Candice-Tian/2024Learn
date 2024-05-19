using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCoreLearn.Migrations
{
    /// <inheritdoc />
    public partial class AddIsVeganForSauce : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsVegan",
                table: "Sauces",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsVegan",
                table: "Sauces");
        }
    }
}
