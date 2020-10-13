using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MiResidencia20.Models;
using SQLite;

namespace MiResidencia20.Data
{
    public class DatabaseQuery
    {
        readonly SQLiteAsyncConnection _database;

        //Creo mi constructor recibe una ruta
        public DatabaseQuery(string dbPath)
        {
            //El contructor recibe un parametro 
            _database = new SQLiteAsyncConnection(dbPath);

            //le paso un objeto/modelo de Usuario global
            _database.CreateTableAsync<Usuario>().Wait();
            

        }

        #region CRUD

        //Declaro una tarea  y una lista recibe parametro de Usuario
        public Task<List<Usuario>> GetUsuarios()
        {
            //Busqueda de Información o Select
            return _database.QueryAsync<Usuario>("select *from Usuario");

        }


        //Insertar Y Actualizar

        public Task<int>SaveUsuarioAsync(Usuario usuario)
        {
            if(usuario.Id != 0)
            {
                return _database.UpdateAsync(usuario);

            }

            else
            {

                return _database.InsertAsync(usuario);
            }


        }

        //Eliminar
        public Task<int> DeleteUsuarioAsync(Usuario usuario)
        {
            return _database.DeleteAsync(usuario);


        }


        #endregion


    }
}
