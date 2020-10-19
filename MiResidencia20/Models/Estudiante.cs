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
        public String Nombre { get; set; } //Loguea para iniciar sesion
        public String Apellido{ get; set; }
        public String Carrera { get; set; }
        public String Grupo { get; set; }
        public String Periodo { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
