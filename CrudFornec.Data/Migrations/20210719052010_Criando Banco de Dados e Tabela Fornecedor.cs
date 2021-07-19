using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudFornec.Data.Migrations
{
    public partial class CriandoBancodeDadoseTabelaFornecedor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateInclusao = table.Column<DateTime>(nullable: false),
                    IsDeletado = table.Column<bool>(nullable: false),
                    RazaoSocial = table.Column<string>(nullable: true),
                    NomeFantasia = table.Column<string>(nullable: true),
                    Cnpj = table.Column<string>(nullable: true),
                    Cep = table.Column<string>(nullable: true),
                    Localidade = table.Column<string>(nullable: true),
                    Numero = table.Column<int>(nullable: false),
                    Complemento = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fornecedor");
        }
    }
}
