using System;
using System.Collections.Generic;
using Xamarin.Forms;
using MiResidencia20.Views.Logueo;
using SQLite;
using MiResidencia20.Models;
using System.IO;
using static MiResidencia20.Models.TablasDB;

namespace MiResidencia20.Views
{
    public partial class RegistroPage : ContentPage
    {
        public RegistroPage()
        {
            InitializeComponent();
       
        }

        async void  Btn_Registrar(System.Object sender, System.EventArgs e)
        {
            //1. Hago mis validaciones para los campos no vacíos
            if (nombreEntry.Text == null || apellidoEntry.Text ==null || carreraEntry.Text == null || grupoEntry.Text == null || periodoEntry.Text == null)
            {
                await DisplayAlert("Error al registrarse", "Llene todos los campos!", "ok");
                
            }
            else
            {
                //2. Empiezo a crear mi base de datos aqui
                var dbpat = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"EstudianteDB.db");
                var db = new SQLiteConnection(dbpat);
                db.CreateTable<Student>();

                //3. Creo mi tabla para los resultados de la Evaluación
                db.CreateTable<ResultEvaluation>();


                //3 Empiezo a crear la base de datos aqui

                var estudiante = new Student()
                {
                    Name = nombreEntry.Text,
                    LastName = apellidoEntry.Text,
                    Career = carreraEntry.Text,
                    Group = grupoEntry.Text,
                    Period = periodoEntry.Text

                };
                db.Insert(estudiante);


                Device.BeginInvokeOnMainThread(async () =>
                {
                    await DisplayAlert("Felicitaciones", "Usuario creado exitosamente", "Ok");
                    await Navigation.PushAsync(new IniciarSesionPage());
                    
                });

            }
        }
    }
     
}
