using System;
using SQLite;

namespace MiResidencia20.Models
{
    //Mi modelo 
    public class Usuario
    {
        [PrimaryKey, AutoIncrement]

        //Declaro mis propiedades
        public int Id { get; set; }
        public  String Nombre { get; set; }
        public String Carrera { get; set; }
        public String Grupo { get; set; }
        public String Periodo { get; set; }
        public DateTime Dato_Creacion { get; set; }



    }
}
