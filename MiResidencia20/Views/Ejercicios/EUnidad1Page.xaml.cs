using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MiResidencia20.Views.Ejercicios;
using Xamarin.Forms;

namespace MiResidencia20.Views.Ejercicios
{

    public partial class EUnidad1Page : ContentPage
    {
        int contadorACiertoCorrecto = 0;

        #region DefinitionsExcercise
        //Básicos 1/3 | Frame.BackgroundColor="#C4ECE7" 
        string[] primerEjercicio =
        {
              //1:R = B. Números naturales
            "1.Son aquellos que no necesitan representarse como una fracción o un decimal." +
            " Además no pueden ser negativos:",

            "A. Números irracionales",
            "B. Números naturales",
            "C. Números enteros"
        };

        string[] segundoEjercicio =
        {
              //2:R = A. Números enteros
            "2. Son números naturales, pero también pueden ser negativos:",
            "A. Números enteros",
            "B. Números irracionales",
            "C. Números naturales"
        };

        string[] tercerEjercicio =
        {
            //3:R = C. Números irracionales
            "3.Son aquellos que no pueden expresarse como la fracción de dos enteros:",
            "A. Números enteros",
            "B. Números naturales",
            "C. Números irracionales"
        };


        //Ejercicio Intermedio 4/6 | Frame.BorderColor="#B0CFF4 "
        string[] cuartoEjercicio =
        {
            //4:R = A.Conmutativa
            "4. Propiedad de los números reales que cuando sumamos o multiplicamos dos números, " +
            "el orden no importa; A+B = B+A, AB=BA:",

            "A. Conmutatativa",
            "B. Distributiva",
            "C. Asociativa",
        };


        string[] quintoEjercicio =
       {
            //5:R = A. Asociativa
            "5. Propiedad de los números reales que cuando sumamos o multiplicamos tres números, " +
                "no importa cuales dos de ellos sumamos o multiplicamos prirmero; " +
                "(A+B)+C = A+(B+C), (AB)C = A(BC):",

            "A. Asociativa",
            "B. Conmutatativa",
            "C. Distributiva"

        };

        #endregion 


        public EUnidad1Page()
        {
            InitializeComponent();
            CargarPreguntaUno();
        }

        public void CargarPreguntaUno()
        {
            //1:R = B. Números naturales
            //Enlazo Xaml con array del Cs
            labelPreguntaDescripcion.Text = primerEjercicio[0];
            labelRespuestaA.Text = primerEjercicio[1];
            labelRespuestaB.Text = primerEjercicio[2];
            labelRespuestaC.Text = primerEjercicio[3];

        }

       
        int contadorClicks = 1;
        void Btn_siguiente(System.Object sender, System.EventArgs e)
        {
            #region SwitchExcersice
            switch (contadorClicks)
            {
                case 1:  //1:R = B. Números naturales

                    // click==1 Ya solo verifica lo que se selecciono de la respuesta por que la  vista ya se cargo
                    if (checkB.IsChecked == true && checkA.IsChecked == false && checkC.IsChecked == false)
                    {
                        contadorACiertoCorrecto += 1;// 1.Le sumo 1 Pt
                        DisplayAlert("Respuesta", $"Correcta", "Ok");//4.Imprimo mensaje correcta
                    }

                    else
                    {
                        if (checkA.IsChecked == false && checkB.IsChecked == false && checkC.IsChecked == false ||
                             checkB.IsChecked == true && checkA.IsChecked == true ||
                             checkB.IsChecked == true && checkC.IsChecked == true ||
                             checkA.IsChecked == true || checkC.IsChecked == true)
                        {
                            contadorACiertoCorrecto += 0;//1. Le sumo 0 pts
                            DisplayAlert("Respuesta", $"Incorrecta", "Ok"); //4.Imprimo mensaje incorrecta
                        }
                    }

                    // NOTA: Adelanto las el formulario de la PREGUNTA 2  
                    labelPreguntaDescripcion.Text = segundoEjercicio[0];
                    labelRespuestaA.Text = segundoEjercicio[1];
                    labelRespuestaB.Text = segundoEjercicio[2];
                    labelRespuestaC.Text = segundoEjercicio[3];
                    break;

                case 2: //2:R = A. Números enteros

                    if (checkA.IsChecked == true && checkB.IsChecked == false && checkC.IsChecked == false)
                    {
                        contadorACiertoCorrecto += 1;
                        DisplayAlert("Respuesta", $"Correcta", "Ok");

                    }

                    else
                    {
                        if (checkA.IsChecked == false && checkB.IsChecked == false && checkC.IsChecked == false ||
                             checkA.IsChecked == true && checkB.IsChecked == true ||
                             checkA.IsChecked == true && checkC.IsChecked == true ||
                             checkB.IsChecked == true || checkC.IsChecked == true)
                        {
                            contadorACiertoCorrecto += 0;//1. Le sumo 0 pts
                            DisplayAlert("Respuesta", $"Incorrecta", "Ok"); //4.Imprimo mensaje incorrecta
                        }
                    }

                    //PREGUNTA 3
                    labelPreguntaDescripcion.Text = tercerEjercicio[0];
                    labelRespuestaA.Text = tercerEjercicio[1];
                    labelRespuestaB.Text = tercerEjercicio[2];
                    labelRespuestaC.Text = tercerEjercicio[3];

                    break;


                case 3: //3:R = C. Números irracionales

                    if (checkC.IsChecked == true && checkA.IsChecked == false && checkB.IsChecked == false)
                    {
                        contadorACiertoCorrecto += 1;
                        DisplayAlert("Respuesta", $"Correcta", "Ok");
                    }

                    else
                    {
                        if ( checkA.IsChecked == false && checkB.IsChecked == false && checkC.IsChecked == false ||
                             checkC.IsChecked == true && checkA.IsChecked == true ||
                             checkC.IsChecked == true && checkB.IsChecked == true ||
                             checkA.IsChecked == true || checkB.IsChecked == true)
                        {
                            contadorACiertoCorrecto += 0;//1. Le sumo 0 pts
                            DisplayAlert("Respuesta", $"Incorrecta", "Ok"); //4.Imprimo mensaje incorrecta
                        }
                    }
                    //PREGUNTA 4
                    labelPreguntaDescripcion.Text = cuartoEjercicio[0];
                    labelRespuestaA.Text = cuartoEjercicio[1];
                    labelRespuestaB.Text = cuartoEjercicio[2];
                    labelRespuestaC.Text = cuartoEjercicio[3];

                    break;

                case 4:  //4:R = A.Conmutativa

                    if (checkA.IsChecked == true && checkB.IsChecked == false && checkC.IsChecked == false)
                    {
                        contadorACiertoCorrecto += 1;
                        DisplayAlert("Respuesta", $"Correcta", "Ok");
                    }
                    else
                    {
                        if ( checkA.IsChecked == false && checkB.IsChecked == false && checkC.IsChecked == false ||
                             checkA.IsChecked == true && checkB.IsChecked == true ||
                             checkA.IsChecked == true && checkC.IsChecked == true ||
                             checkB.IsChecked == true || checkC.IsChecked == true)
                        {
                            contadorACiertoCorrecto += 0;//1. Le sumo 0 pts
                            DisplayAlert("Respuesta", $"Incorrecta", "Ok"); //4.Imprimo mensaje incorrecta
                        }
                    }

                    //PREGUNTA 5
                    labelPreguntaDescripcion.Text = quintoEjercicio[0];
                    labelRespuestaA.Text = quintoEjercicio[1];
                    labelRespuestaB.Text = quintoEjercicio[2];
                    labelRespuestaC.Text = quintoEjercicio[3];

                    break;

                case 5: //5:R = A. Asociativa

                    if (checkA.IsChecked == true && checkB.IsChecked == false && checkC.IsChecked == false)
                    {
                        DisplayAlert("Respuesta", $"Correcta", "Ok");
                        contadorACiertoCorrecto += 1;
                    }
                    else
                    {
                        if ( checkA.IsChecked == false && checkB.IsChecked == false && checkC.IsChecked == false ||
                             checkA.IsChecked == true && checkB.IsChecked == true ||
                             checkA.IsChecked == true && checkC.IsChecked == true ||
                             checkB.IsChecked == true || checkC.IsChecked == true)
                        {
                            contadorACiertoCorrecto += 0;//1. Le sumo 0 pts
                            DisplayAlert("Respuesta", $"Incorrecta", "Ok"); //4.Imprimo mensaje incorrecta
                        }
                    }
                    break;

                case 6: //Mostrar Calificación de Acierto 1*20%
                    var calificacionPorcentaje = contadorACiertoCorrecto * 20;

                    if (calificacionPorcentaje >= 80)
                    {
                        DisplayAlert("CALIFICACIÓN", $"{calificacionPorcentaje}% , ¡Felicitaciones vas bien sigue así!", "Ok");
                        Navigation.PopAsync();
                    }

                    else
                    { //calicación <80
                        DisplayAlert("CALIFICACIÓN", $"{calificacionPorcentaje}% , ¡Te falta mejorar un poco más!", "Ok");
                        Navigation.PopAsync();
                    }
                    break;

            }//Switch
            LimpiarChecks();
            contadorClicks++;

            #endregion
        }//Button

        #region Methods
        public void LimpiarChecks()
        {
            checkA.IsChecked = false;
            checkB.IsChecked = false;
            checkC.IsChecked = false;

        }
        #endregion Methods

    }

}
    