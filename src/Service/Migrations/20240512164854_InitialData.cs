using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Service.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                "Numbers", 
                new string[] { "Id", "Value" }, 
                new string[] {"INTEGER", "INTEGER"}, 
                new object[,] { 
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 9 },
                    { 10, 10 },
                    { 11, 11 },
                    { 12, 12 },
                    { 13, 13 },
                    { 14, 14 },
                });

            migrationBuilder.InsertData("Cards", 
                new string[] { "Id", "Name", "Price", "Action", "Type", "MaxCount", "IsInitial", "Level"}, 
                new string[] {"INTEGER", "TEXT", "INTEGER", "TEXT", "INTEGER", "INTEGER", "BOOLEAN", "INTEGER"}, 
                new object[,] { 
                    { 1, "Вокзал", 4, "Можно бросать 2 кубика вместо 1. В свой ход.", 1, 5, 1, 1 },
                    { 2, "Торговый центр", 10, "Каждое ваше предприятие с символом кружки или пакета приносит на 1 монету больше.", 1, 5, 1, 1 },
                    { 3, "Парк развлечений", 16, "Если на кубиках выпал дубль сделайте еще один ход. В свой ход.", 1, 5, 1, 1 },
                    { 4, "Радиовышка", 23, "Один раз можете перебросить кубики. В свой ход.", 1, 5, 1, 1 },
                    { 5, "Пщеничное поле", 1, "Возьмите 1 монету из банка. В ход любого игрока.", 2, 11, 1, 1 },
                    { 6, "Ферма", 1, "Возьмите 1 монету из банка. В ход любого игрока.", 2, 6, 0, 1 },
                    { 7, "Лес", 3, "Возьмите 1 монету из банка. В ход любого игрока.", 2, 6, 0, 1 },
                    { 8, "Пекарня", 1, "Возьмите 1 монету из банка. В свой ход.", 3, 11, 1, 1 },
                    { 9, "Магазин", 2, "Возьмите 3 монеты из банка. В свой ход.", 3, 6, 0, 1 },
                    { 10, "Стадион", 6, "Возьмите 2 монеты у каждого игрока. В свой ход.", 4, 5, 0, 1 },
                    { 11, "Кафе", 2, "Возьмите 1 монету у игрока, бросившего кубики. В ход другого игрока.", 5, 6, 0, 1 },
                });

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
