using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoFinalPietra.Migrations
{
    public partial class CriacaoControler2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ObservacaoRealizacao",
                table: "Procedimentorealizado",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ObservacaoRealizacao",
                table: "Procedimentorealizado",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
