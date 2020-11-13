using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System;

namespace Tarea9_10
{
    public class Conexion: DbContext
    {
        public DbSet<Integrante> Integrantes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=Church.db");
    }

    public class Integrante
    {
        public int IntegranteId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Foto { get; set; }
        public DateTime Fecha_Nacimiento  { get; set; }
        public string Pais_Nacimiento { get; set; }
        public string Ciudad_Nacimiento { get; set; }
        public string Pais_Residencia { get; set; }
        public string Ciudad_Residencia { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Numero { get; set; }
        public string Correo { get; set; }
        public string Tipo_Documento { get; set; }
        public string Documento { get; set; }
        public bool Estado_Civil { get; set; }
        public string Nombre_Conyuge { get; set; }
        public bool Hijos { get; set; }
        public int Cantidad_Hijos { get; set; }
        public string Profesion { get; set; }
        public string Ocupacion_Actual { get; set; }
        public string Nombre_Empresa { get; set; }
        public string Telefono_Empresa { get; set; }
        public DateTime Fecha_Conversion { get; set; }
        public DateTime Fecha_Bautismo { get; set; }
        public DateTime Fecha_Miembro { get; set; }
        public string Denominacion { get; set; }
        public string Nombre_Iglesia { get; set; }
        public string Congregacion_Anterior { get; set; }
        public string Nombre_Pastor { get; set; }
        public bool Disciplina { get; set; }
        public int Cantidad_Disciplina { get; set; }
        public string Causas_Disciplina { get; set; }
        public string Ocupaciones { get; set; }
        public string Pregunta1 { get; set; }
        public string Pregunta2 { get; set; }
        public string Pregunta3 { get; set; }
        public string Pregunta4 { get; set; }
        public string Pregunta5 { get; set; }
        public string Nivel_Estudio { get; set; }
        public bool Expulsado { get; set; }
        public string Razon_Expulsion { get; set; }

    }

}