using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Service.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "machikoro");

            migrationBuilder.CreateTable(
                name: "Cards",
                schema: "machikoro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<int>(type: "INTEGER", nullable: false),
                    Action = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxCount = table.Column<int>(type: "INTEGER", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Numbers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Value = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Numbers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "machikoro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CardNumber",
                columns: table => new
                {
                    CardsId = table.Column<int>(type: "INTEGER", nullable: false),
                    NumbersId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardNumber", x => new { x.CardsId, x.NumbersId });
                    table.ForeignKey(
                        name: "FK_CardNumber_Cards_CardsId",
                        column: x => x.CardsId,
                        principalSchema: "machikoro",
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardNumber_Numbers_NumbersId",
                        column: x => x.NumbersId,
                        principalTable: "Numbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    OwnerId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "machikoro",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GameUser",
                columns: table => new
                {
                    GamesId = table.Column<string>(type: "TEXT", nullable: false),
                    UsersId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameUser", x => new { x.GamesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_GameUser_Games_GamesId",
                        column: x => x.GamesId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalSchema: "machikoro",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardNumber_NumbersId",
                table: "CardNumber",
                column: "NumbersId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_OwnerId",
                table: "Games",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_GameUser_UsersId",
                table: "GameUser",
                column: "UsersId");

            // init data
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
            migrationBuilder.DropTable(
                name: "CardNumber");

            migrationBuilder.DropTable(
                name: "GameUser");

            migrationBuilder.DropTable(
                name: "Cards",
                schema: "machikoro");

            migrationBuilder.DropTable(
                name: "Numbers");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "machikoro");
        }
    }
}
