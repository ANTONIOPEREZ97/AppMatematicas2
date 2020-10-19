using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MiResidencia20.Models;
using SQLite;

namespace MiResidencia20.Data
{

    public class DatabaseContext
    {
        //1. Defino mi propiedad para la conexion
        public SQLiteAsyncConnection Connection { get; set;}

        
        public DatabaseContext( string path)
        {
            //2.Inicializo la conexion y le envio la ruta
            Connection = new SQLiteAsyncConnection(path);
            Connection.CreateTableAsync<Estudiante>().Wait();//Espero su creacion con el wait

        }

        //3.Meto-do necesario para guardar un objeto de tipo estudiante 
        public async  Task<int>InsertItemEstudianteAsync (Estudiante estudiante)
        {

            return await Connection.InsertAsync(estudiante);
        }


        //4. Para listar los elementos de la base de datos

        public async Task<List<Estudiante>> GetItemEstudiantesAsync()
        {     
            return await Connection.Table<Estudiante>().ToListAsync();


        }

        //5. Meto-do Delete de la lista de datos
        public async  Task<int> DeleteItemsEstudiantesAsync(Estudiante estudiante)
        {

            return await Connection.DeleteAsync(estudiante);
        }






    }
    
}
