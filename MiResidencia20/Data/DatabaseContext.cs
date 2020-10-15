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







    }

    #region FirstImplements BD
    //<! Implementacion de 1ERA BASE DE DATOS!>
    //public class DatabaseQuery
    //{
    //    readonly SQLiteAsyncConnection _database;

    //    //Creo mi constructor recibe una ruta de la base de datos
    //    public DatabaseQuery(string dbPath)
    //    {
    //        //El contructor recibe un parametro 
    //        _database = new SQLiteAsyncConnection(dbPath);

    //        //le paso un objeto/modelo de Estudiante global
    //        _database.CreateTableAsync<Estudiante>().Wait();


    //    }

    //    #region CRUD


    //    //Insertar Y Actualizar

    //    public Task<int>SaveEstudianteAsync(Estudiante estudiante)
    //    {
    //        if(estudiante.Id != 0)
    //        {
    //            return _database.UpdateAsync(estudiante);
    //        }

    //        else
    //        {
    //            return _database.InsertAsync(estudiante);
    //        }


    //    }


    //    //METOD0 SELECT() * para listar mis datos de la table insertados

    //    public Task<List<Estudiante>>GetEstudiante()
    //    {
    //        return _database.Table<Estudiante>().ToListAsync();

    //    }


    //    //Eliminar
    //    public Task<int> DeleteEstudianteAsync(Estudiante estudiante)
    //    {
    //        return _database.DeleteAsync(estudiante);
    //    }


    //    #endregion


    //}

    #endregion
}
