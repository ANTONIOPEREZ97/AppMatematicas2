using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using static MiResidencia20.Models.TablasDB;

namespace MiResidencia20.Views.Menu
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

       //1.Para poder listar en el listview
        protected override void OnAppearing()
        {
            base.OnAppearing();
            CargarDatosEstudiantes();
        }

        //2. Me sirve para cargar los datos  || estaba en privado
          void CargarDatosEstudiantes()
        {

            // var items = await App.Context.GetItemEstudiantesAsync();
            //Enlazo con mi propiedad xaml listview  listaDatosAlumnos x:Name de listView 
            // ListaDatosAlumno.ItemsSource = items;

            //USO DE LA BASE DE DATOS CONSULTANDO LA TABLA Student
            var dbpat = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "EstudianteDB.db");
            var db = new SQLiteConnection(dbpat);

            var studentquery = db.Table<Student>().ToList();

            //IMPRIMO LOS DATOS REGISTRADOS EN EL  FORMULARIO RegistroPage
            ListaDatosEstudiante.ItemsSource = studentquery;
            

        }
    }
}
