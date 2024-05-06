using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Service.Migrations
{
    /// <inheritdoc />
    public partial class InitialData_Cards : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Cards", 
                new string[] { "Id", "Name", "Price", "Action", "Type", "MaxCount", "Level"}, 
                new string[] {"INTEGER", "TEXT", "INTEGER", "TEXT", "INTEGER", "INTEGER", "INTEGER"}, 
                new object[] {1, "Вокзал", 4, "Можно кидать 2 кубика", 1, 5, 1});
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
