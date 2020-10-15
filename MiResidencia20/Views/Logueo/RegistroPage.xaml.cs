using System;
using System.Collections.Generic;
using Xamarin.Forms;
using MiResidencia20.Views.Logueo;
using MiResidencia20.Models;
using SQLite;

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
            if (nombreCompletoEntry.Text == null || carreraEntry.Text == null || grupoEntry.Text == null || periodoEntry.Text == null)
            {
                await DisplayAlert("Error al registrarse", "Llene todos los campos!", "ok");
            }
            else
            {
                await DisplayAlert("Felicitaciones", "¡Usuario creado exitosamente!", "Ok");
                await Navigation.PushAsync(new MenuTabbedPage());

            }

            //2.Me sirve si en dado caso exista un error al almacenar en la base de datos
            try
            {
                //3. Declaro una variable para almacenar el modelo Estudiante
                var estudiante = new Estudiante
                {
                    NombreCompleto = nombreCompletoEntry.Text,//Tolower=Minusculas
                    Carrera = carreraEntry.Text,
                    Grupo = grupoEntry.Text,
                    Periodo = periodoEntry.Text,
                    FechaCreacion = DateTime.UtcNow.Date
                };

                var result = App.Context.InsertItemEstudianteAsync(estudiante);

                //if (result ==1)
                //{
                //    await Navigation.PushAsync(new MenuTabbedPage());

                //}
                //else
                //{
                //    await DisplayAlert("Error", "No se pudo guardar los datos", "Ok");
                //}
         
            }
            catch (Exception ex)
            {

                await DisplayAlert("Error",ex.Message, "ok");
            }

        }
    }
     
}
