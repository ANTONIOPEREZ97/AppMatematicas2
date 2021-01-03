using System;
using System.Collections.Generic;
using System.IO;
using MiResidencia20.Views.Logueo;
using SQLite;
using Xamarin.Forms;
using static MiResidencia20.Models.TablasDB;

namespace MiResidencia20.Views.Menu
{
    public partial class PorcentajeEvaluacionPage : ContentPage
    {
       
        public PorcentajeEvaluacionPage()
        {
            InitializeComponent();

            //USO DE LA BASE DE DATOS CONSULTANDO LA TABLA ResultEvaluation
            var dbpat = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "EstudianteDB.db");
            var db = new SQLiteConnection(dbpat);

            var resultevalutionquery = db.Table<ResultEvaluation>();

            //IMPRIMO LAS CALIFICACIONES DESDE DE LA BASE DE DATOS
            foreach (var item1 in resultevalutionquery)
            {
                lbl_evalUnidad1.Text = item1.ResultUnit1.ToString();// De int convierto a string por el label.text
            }

            foreach (var item2 in resultevalutionquery)
            {
                lbl_evalUnidad2.Text = item2.ResultUnit2.ToString();
            }

            foreach (var item3 in resultevalutionquery)
            {
                lbl_evalUnidad3.Text = item3.ResultUnit3.ToString();
            }

            foreach (var item4 in resultevalutionquery)
            {
                lbl_evalUnidad4.Text = item4.ResultUnit4.ToString();
            }

            foreach (var item5 in resultevalutionquery)
            {
                lbl_evalUnidad5.Text = item5.ResultUnit5.ToString();
            }

            foreach (var item6 in resultevalutionquery)
            {
                lbl_evalUnidad6.Text = item6.ResultUnit6.ToString();
            }

            foreach (var item7 in resultevalutionquery)
            {
                lbl_evalUnidad7.Text = item7.ResultUnit7.ToString();
            }

            foreach (var item8 in resultevalutionquery)
            {
                lbl_evalUnidad8.Text = item8.ResultUnit8.ToString();
            }

            foreach (var item9 in resultevalutionquery)
            {
                lbl_evalUnidad9.Text = item9.ResultUnit9.ToString();
            }
        }

        #region NavigationMenu
        void Btn_IrAMenuPrincipal(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MenuTabbedPage());
        }

        #endregion
    }
}
