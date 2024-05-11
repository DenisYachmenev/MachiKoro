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
                    { 2, "Торговый центр", 10, "Каждое ваше предприятие с символом кружки или пакета приносит на 1 монету больше.", 1, 5, 1 },
                    { 3, "Парк развлечений", 16, "Если на кубиках выпал дубль сделайте еще один ход. В свой ход.", 1, 5, 1 },
                    { 4, "Радиовышка", 23, "Один раз можете перебросить кубики. В свой ход.", 1, 5, 1 },
                    { 5, "Пщеничное поле", 1, "Возьмите 1 монету из банка. В ход любого игрока.", 2, 11, 1 },
                    { 6, "Ферма", 1, "Возьмите 1 монету из банка. В ход любого игрока.", 2, 6, 1 },
                    { 7, "Лес", 3, "Возьмите 1 монету из банка. В ход любого игрока.", 2, 6, 1 },
                    { 8, "Пекарня", 1, "Возьмите 1 монету из банка. В свой ход.", 3, 11, 1 },
                    { 9, "Магазин", 2, "Возьмите 3 монеты из банка. В свой ход.", 3, 6, 1 },
                    { 10, "Стадион", 6, "Возьмите 2 монеты у каждого игрока. В свой ход.", 4, 5, 1 },
                    { 11, "Кафе", 2, "Возьмите 1 монету у игрока, бросившего кубики. В ход другого игрока.", 5, 6, 1 },
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
