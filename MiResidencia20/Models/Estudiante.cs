using System;
using SQLite;

namespace MiResidencia20.Models
{
    //Mi modelo 
    public class Estudiante
    {
        [PrimaryKey, AutoIncrement,NotNull]
        //Declaro mis propiedades
        public int Id { get; set; }
        public string Nombre { get; set; } //Nombre de logueo para iniciar sesion
        public string Apellido{ get; set; }
        public string Carrera { get; set; }
        public string Grupo { get; set; }
        public string Periodo { get; set; }
        public DateTime FechaCreacion { get; set; }

    }
}
