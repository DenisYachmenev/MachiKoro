using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Service.Migrations
{
    /// <inheritdoc />
    public partial class InitialData_Numbers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Numbers", new string[] { "Id", "Value" }, 
                new string[] {"INTEGER", "INTEGER"}, new object[] {1, 1});
            migrationBuilder.InsertData("Numbers", new string[] { "Id", "Value" }, 
                new string[] {"INTEGER", "INTEGER"}, new object[] {2, 2});
            migrationBuilder.InsertData("Numbers", new string[] { "Id", "Value" }, 
                new string[] {"INTEGER", "INTEGER"}, new object[] {3, 3});
            migrationBuilder.InsertData("Numbers", new string[] { "Id", "Value" }, 
                new string[] {"INTEGER", "INTEGER"}, new object[] {4, 4});
            migrationBuilder.InsertData("Numbers", new string[] { "Id", "Value" }, 
                new string[] {"INTEGER", "INTEGER"}, new object[] {5, 5});
            migrationBuilder.InsertData("Numbers", new string[] { "Id", "Value" }, 
                new string[] {"INTEGER", "INTEGER"}, new object[] {6, 6});
            migrationBuilder.InsertData("Numbers", new string[] { "Id", "Value" }, 
                new string[] {"INTEGER", "INTEGER"}, new object[] {7, 7});
            migrationBuilder.InsertData("Numbers", new string[] { "Id", "Value" }, 
                new string[] {"INTEGER", "INTEGER"}, new object[] {8, 8});
            migrationBuilder.InsertData("Numbers", new string[] { "Id", "Value" }, 
                new string[] {"INTEGER", "INTEGER"}, new object[] {9, 9});
            migrationBuilder.InsertData("Numbers", new string[] { "Id", "Value" }, 
                new string[] {"INTEGER", "INTEGER"}, new object[] {10, 10});
            migrationBuilder.InsertData("Numbers", new string[] { "Id", "Value" }, 
                new string[] {"INTEGER", "INTEGER"}, new object[] {11, 11});
            migrationBuilder.InsertData("Numbers", new string[] { "Id", "Value" }, 
                new string[] {"INTEGER", "INTEGER"}, new object[] {12, 12});
        }
    }
}
