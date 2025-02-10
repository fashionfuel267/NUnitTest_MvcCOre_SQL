using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class ii : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LookUps",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LookUpType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookUps", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "LookUps",
                columns: new[] { "Code", "Description", "LookUpType" },
                values: new object[,]
                {
                    { "AK", "Alaska", 0 },
                    { "AL", "Alabama", 0 },
                    { "AR", "Arkansas", 0 },
                    { "AZ", "Arizona", 0 },
                    { "CA", "California", 0 },
                    { "CO", "Colorado", 0 },
                    { "CT", "Connecticut", 0 },
                    { "DC", "District of Columbia", 0 },
                    { "DE", "Delaware", 0 },
                    { "FL", "Florida", 0 },
                    { "GA", "Georgia", 0 },
                    { "IA", "Indiana", 0 },
                    { "ID", "Hawaii", 0 },
                    { "IL", "Idaho", 0 },
                    { "IN", "Illinois", 0 },
                    { "KS", "Iowa", 0 },
                    { "KY", "Kansas", 0 },
                    { "LA", "Kentucky", 0 },
                    { "MA", "Maryland", 0 },
                    { "MD", "Maine", 0 },
                    { "ME", "Louisiana", 0 },
                    { "MI", "Massachusetts", 0 },
                    { "MN", "Michigan", 0 },
                    { "MO", "Mississippi", 0 },
                    { "MS", "Minnesota", 0 },
                    { "MT", "Missouri", 0 },
                    { "NC", "New Carolina", 0 },
                    { "ND", "North Dakota", 0 },
                    { "NE", "Montana", 0 },
                    { "NH", "New Hampshire", 0 },
                    { "NJ", "New Jersey", 0 },
                    { "NM", "New Mexico", 0 },
                    { "NV", "Nevada", 0 },
                    { "NY", "New York", 0 },
                    { "OH", "Ohio", 0 },
                    { "OK", "Oklahoma", 0 },
                    { "OR", "Oregon", 0 },
                    { "PA", "Pennsylvania", 0 },
                    { "PR", "Puerto Rico", 0 },
                    { "RI", "Rhode Island", 0 },
                    { "SC", "South Carolina", 0 },
                    { "SD", "South Dakota", 0 },
                    { "TN", "Tennessee", 0 },
                    { "TX", "Texas", 0 },
                    { "USA", "United States of America", 1 },
                    { "UT", "Utah", 0 },
                    { "VA", "Virginia", 0 },
                    { "VT", "Vermont", 0 },
                    { "WA", "Washington", 0 },
                    { "WI", "Wisconsis", 0 },
                    { "WV", "West Virginia", 0 },
                    { "WY", "Wyoming", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_PersonId",
                table: "Addresses",
                column: "PersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "LookUps");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
