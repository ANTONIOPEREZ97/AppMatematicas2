using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MiResidencia20.Views.Ejercicios
{
    public partial class EUnidad6Page : ContentPage
    {
        int contadorACiertoCorrecto = 0;

        #region DefinitionsExcercise
        string[] primerEjercicio =
        {
            //1:R = C. Principal
            "1. En la fórmula I =  Prt para interés simple, P representa: ",

            "A. Cantidad de interés",
            "B. Tasa de interés",
            "C. *Principal"
        };

        string[] segundoEjercicio =
        {
              //2:R = B. Identificar la variable
            "2. Para  modelar una ecuación  el primer paso es:",

            "A. Transformar las palabras en álgebra",
            "B. *Identificar la variable",
            "C. Formular el modelo "
        };

        string[] tercerEjercicio =
        {
            //3:R = A. C = x/V
            "3. Para modelar un problema de mezclas y concentraciones la C de sustacia está dada por:",

            "A. *C = x/V",
            "B.  C= V/x",
            "C. Ninguna de las anteriores"
        };


        string[] cuartoEjercicio =
        {
            //4:R = C. Sustancia disolvente 
            "4. De la pregunta anterior, la x de la forma significa :",

            "A. Volumen de sustancia",
            "B. Concentración de sustancia",
            "C. *Sustancia disolvente  "
        };

        string[] quintoEjercicio =
       {
            //5:R = A. distancia =  rapidez x tiempo
            "5. La formula correcta para resolver problemas de distancia, rapidez y tiempo es:",

            "A. *distancia =  rapidez x tiempo",
            "B. distancia = rapidez / tiempo",
            "C. distancia² = rapidez  x tiempo"
        };

        #endregion
        public EUnidad6Page()
        {
            InitializeComponent();
            CargarPreguntaUno();
        }

        public void CargarPreguntaUno()
        {
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
                case 1:   //1:R = C. Principal

                    // click==1 Ya solo verifica lo que se selecciono de la respuesta por que la  vista ya se cargo antes
                    if (checkC.IsChecked == true && checkA.IsChecked == false && checkB.IsChecked == false)
                    {
                        contadorACiertoCorrecto += 1;// 1.Le sumo 1 Pt
                        DisplayAlert("Respuesta", $"Correcta", "Ok");//4.Imprimo mensaje correcta
                    }

                    else
                    {
                        if (checkA.IsChecked == false && checkB.IsChecked == false && checkC.IsChecked == false ||
                             checkC.IsChecked == true && checkA.IsChecked == true ||
                             checkC.IsChecked == true && checkB.IsChecked == true ||
                             checkA.IsChecked == true || checkB.IsChecked == true)
                        {
                            contadorACiertoCorrecto += 0;//1. Le sumo 0 pts
                            DisplayAlert("Respuesta", $"Incorecta", "Ok"); //4.Imprimo mensaje incorrecta

                        }
                    }

                    // NOTA: Adelanto las el formulario de la PREGUNTA 2  
                    labelPreguntaDescripcion.Text = segundoEjercicio[0];
                    labelRespuestaA.Text = segundoEjercicio[1];
                    labelRespuestaB.Text = segundoEjercicio[2];
                    labelRespuestaC.Text = segundoEjercicio[3];
                    break;

                case 2:   //2:R = B. Identificar la variable

                    if (checkB.IsChecked == true && checkA.IsChecked == false && checkC.IsChecked == false)
                    {
                        contadorACiertoCorrecto += 1;
                        DisplayAlert("Respuesta", $"Correcta", "Ok");

                    }

                    else
                    {
                        if (checkA.IsChecked == false && checkB.IsChecked == false && checkC.IsChecked == false ||
                             checkB.IsChecked == true && checkA.IsChecked == true ||
                             checkB.IsChecked == true && checkC.IsChecked == true ||
                             checkA.IsChecked == true || checkC.IsChecked == true)
                        {
                            contadorACiertoCorrecto += 0;//1. Le sumo 0 pts
                            DisplayAlert("Respuesta", $"Incorecta", "Ok"); //4.Imprimo mensaje incorrecta

                        }
                    }

                    //PREGUNTA 3
                    labelPreguntaDescripcion.Text = tercerEjercicio[0];
                    labelRespuestaA.Text = tercerEjercicio[1];
                    labelRespuestaB.Text = tercerEjercicio[2];
                    labelRespuestaC.Text = tercerEjercicio[3];

                    break;


                case 3:  //3:R = A. C = x/V

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
                            DisplayAlert("Respuesta", $"Incorecta", "Ok"); //4.Imprimo mensaje incorrecta

                        }
                    }
                    //PREGUNTA 4
                    labelPreguntaDescripcion.Text = cuartoEjercicio[0];
                    labelRespuestaA.Text = cuartoEjercicio[1];
                    labelRespuestaB.Text = cuartoEjercicio[2];
                    labelRespuestaC.Text = cuartoEjercicio[3];

                    break;

                case 4:   //4:R = C. Sustancia disolvente 

                    if (checkC.IsChecked == true && checkA.IsChecked == false && checkB.IsChecked == false)
                    {
                        contadorACiertoCorrecto += 1;
                        DisplayAlert("Respuesta", $"Correcta", "Ok");
                    }

                    else
                    {
                        if (checkA.IsChecked == false && checkB.IsChecked == false && checkC.IsChecked == false ||
                             checkC.IsChecked == true && checkA.IsChecked == true ||
                             checkC.IsChecked == true && checkB.IsChecked == true ||
                             checkA.IsChecked == true || checkB.IsChecked == true)
                        {
                            contadorACiertoCorrecto += 0;//1. Le sumo 0 pts
                            DisplayAlert("Respuesta", $"Incorecta", "Ok"); //4.Imprimo mensaje incorrecta

                        }
                    }

                    //PREGUNTA 5
                    labelPreguntaDescripcion.Text = quintoEjercicio[0];
                    labelRespuestaA.Text = quintoEjercicio[1];
                    labelRespuestaB.Text = quintoEjercicio[2];
                    labelRespuestaC.Text = quintoEjercicio[3];

                    break;

                case 5:   // 5:R = A.distancia = rapidez x tiempo


                    if (checkA.IsChecked == true && checkB.IsChecked == false && checkC.IsChecked == false)
                    {
                        DisplayAlert("Respuesta", $"Correcta", "Ok");
                        contadorACiertoCorrecto += 1;

                    }

                    else
                    {
                        if (checkA.IsChecked == false && checkB.IsChecked == false && checkC.IsChecked == false ||
                             checkA.IsChecked == true && checkB.IsChecked == true ||
                             checkA.IsChecked == true && checkC.IsChecked == true ||
                             checkB.IsChecked == true || checkC.IsChecked == true)
                        {
                            contadorACiertoCorrecto += 0;//1. Le sumo 0 pts
                            DisplayAlert("Respuesta", $"Incorecta", "Ok"); //4.Imprimo mensaje incorrecta

                        }
                    }

                    break;


                case 6: //Mostrar Calificación de Acierto 1*20%
                    var calificacionPorcentaje = contadorACiertoCorrecto * 20;

                    if (calificacionPorcentaje >= 80)
                    {
                        DisplayAlert("CALIFICACIÓN", $"{calificacionPorcentaje}% , Felicitaciones sigue así!", "Ok");
                        Navigation.PopAsync();
                    }

                    else
                    { //calicación <80
                        DisplayAlert("CALIFICACIÓN", $"{calificacionPorcentaje}% , Nunca dejes de aprender!", "Ok");
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
