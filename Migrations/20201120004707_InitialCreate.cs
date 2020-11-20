using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChurchApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Integrantes",
                columns: table => new
                {
                    IntegranteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Sexo = table.Column<string>(type: "TEXT", nullable: true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Apellidos = table.Column<string>(type: "TEXT", nullable: true),
                    Foto = table.Column<string>(type: "TEXT", nullable: true),
                    Fecha_Nacimiento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Pais_Nacimiento = table.Column<string>(type: "TEXT", nullable: true),
                    Ciudad_Nacimiento = table.Column<string>(type: "TEXT", nullable: true),
                    Pais_Residencia = table.Column<string>(type: "TEXT", nullable: true),
                    Ciudad_Residencia = table.Column<string>(type: "TEXT", nullable: true),
                    Direccion = table.Column<string>(type: "TEXT", nullable: true),
                    Telefono = table.Column<string>(type: "TEXT", nullable: true),
                    Numero = table.Column<string>(type: "TEXT", nullable: true),
                    Correo = table.Column<string>(type: "TEXT", nullable: true),
                    Tipo_Documento = table.Column<string>(type: "TEXT", nullable: true),
                    Documento = table.Column<string>(type: "TEXT", nullable: true),
                    Estado_Civil = table.Column<string>(type: "TEXT", nullable: true),
                    Nombre_Conyuge = table.Column<string>(type: "TEXT", nullable: true),
                    Hijos = table.Column<string>(type: "TEXT", nullable: true),
                    Cantidad_Hijos = table.Column<int>(type: "INTEGER", nullable: false),
                    Profesion = table.Column<string>(type: "TEXT", nullable: true),
                    Ocupacion = table.Column<string>(type: "TEXT", nullable: true),
                    Nombre_Empresa = table.Column<string>(type: "TEXT", nullable: true),
                    Telefono_Empresa = table.Column<string>(type: "TEXT", nullable: true),
                    Fecha_Conversion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Fecha_Bautismo = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Fecha_Miembro = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Denominacion = table.Column<string>(type: "TEXT", nullable: true),
                    Nombre_Iglesia = table.Column<string>(type: "TEXT", nullable: true),
                    Congregacion_Anterior = table.Column<string>(type: "TEXT", nullable: true),
                    Nombre_Pastor = table.Column<string>(type: "TEXT", nullable: true),
                    Disciplina = table.Column<string>(type: "TEXT", nullable: true),
                    Cantidad_Disciplina = table.Column<int>(type: "INTEGER", nullable: false),
                    Causas_Disciplina = table.Column<string>(type: "TEXT", nullable: true),
                    Ocupaciones = table.Column<string>(type: "TEXT", nullable: true),
                    Pregunta1 = table.Column<string>(type: "TEXT", nullable: true),
                    Pregunta2 = table.Column<string>(type: "TEXT", nullable: true),
                    Pregunta3 = table.Column<string>(type: "TEXT", nullable: true),
                    Pregunta4 = table.Column<string>(type: "TEXT", nullable: true),
                    Pregunta5 = table.Column<string>(type: "TEXT", nullable: true),
                    Nivel_Estudio = table.Column<string>(type: "TEXT", nullable: true),
                    Expulsado = table.Column<string>(type: "TEXT", nullable: true),
                    Razon_Expulsion = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Integrantes", x => x.IntegranteId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Integrantes");
        }
    }
}
