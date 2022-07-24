using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleFinanceiroApi.Migrations
{
    public partial class atualizadocore6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_ContaPagar",
                columns: table => new
                {
                    ContaPagarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DataPagamento = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Valor = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ContaPagar", x => x.ContaPagarID);
                });

            migrationBuilder.CreateTable(
                name: "TB_Receita",
                columns: table => new
                {
                    ReceitaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DataRecebimento = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Valor = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Receita", x => x.ReceitaID);
                });

            migrationBuilder.CreateTable(
                name: "TB_Usuario",
                columns: table => new
                {
                    UsuarioID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Login = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Usuario", x => x.UsuarioID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_ContaPagar");

            migrationBuilder.DropTable(
                name: "TB_Receita");

            migrationBuilder.DropTable(
                name: "TB_Usuario");
        }
    }
}
