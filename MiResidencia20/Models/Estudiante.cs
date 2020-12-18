using System;
using SQLite;

namespace MiResidencia20.Models
{
    //Mi modelo 
    public class Estudiante
    {
        [PrimaryKey, AutoIncrement,NotNull]
        //Declaro mis propiedades recomendables en ingles
        public int Id { get; set; }
        public string Name { get; set; } //Nombre de logueo para iniciar sesion
        public string LastName{ get; set; }
        public string Career { get; set; }
        public string Group { get; set; }
        public string Period { get; set; }
        public DateTime CreationDate { get; set; }

    }
}
