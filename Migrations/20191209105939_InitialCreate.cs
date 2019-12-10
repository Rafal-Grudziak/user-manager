using Microsoft.EntityFrameworkCore.Migrations;

namespace users.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    u_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    u_Type = table.Column<int>(nullable: false),
                    U_Active = table.Column<bool>(nullable: false),
                    U_Code = table.Column<string>(type: "varchar(60)", nullable: false),
                    u_ForeignId = table.Column<int>(nullable: false),
                    u_ForeignCode = table.Column<string>(type: "varchar(60)", nullable: true),
                    u_Name = table.Column<string>(type: "varchar(100)", nullable: true),
                    u_Pwd = table.Column<string>(type: "varchar(60)", nullable: false),
                    u_MachineID = table.Column<int>(nullable: false),
                    u_DefaultLanguage = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.u_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
