using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Service.Migrations
{
    /// <inheritdoc />
    public partial class InitialData_CardNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("CardNumber", 
                new string[] { "CardsId", "NumbersId"}, 
                new string[] {"INTEGER", "INTEGER"}, 
                new object[,] { 
                    { 5, 1 },
                    { 6, 2 },
                    { 7, 5 },
                    { 8, 2 },
                    { 8, 3 },
                    { 9, 4 },
                    { 10, 6 },
                    { 11, 3 },
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
