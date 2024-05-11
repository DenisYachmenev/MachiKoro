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
                new object[,] { 
                    { 1, "Вокзал", 4, "Можно бросать 2 кубика вместо 1. В свой ход.", 1, 5, 1 },
                    { 1, "Торговый центр", 10, "Каждое ваше предприятие с символом кружки или пакета приносит на 1 монету больше.", 1, 5, 1 },
                    { 1, "парк развлечений", 16, "Если на кубиках выпал дубль сделайте еще один ход. В свой ход.", 1, 5, 1 },
                    { 1, "Радиовышка", 23, "Один раз можете перебросить кубики. В свой ход.", 1, 5, 1 },
                    { 1, "Вокзал", 4, "Можно кидать 2 кубика", 1, 5, 1 },
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
