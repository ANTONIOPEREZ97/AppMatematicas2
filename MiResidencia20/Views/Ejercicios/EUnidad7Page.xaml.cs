using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MiResidencia20.Views.Ejercicios
{
    public partial class EUnidad7Page : ContentPage
    {
        int contadorACiertoCorrecto = 0;

        #region DefinitionsExcercise
        string[] primerEjercicio =
        {
            //1:R = A. Elevación y corrimiento
            "1. La pendiente de una recta es la relación entre :",

            "A. *Elevación y corrimiento",
            "B. Elevación y pendiente",
            "C. Inclinación y pendiente"
        };

        string[] segundoEjercicio =
        {
              //2:R = B. m= y2 - y1 / x2 – x1 
            "2. Formula de la  pendiente de una recta m que pasa por los dos puntos A y B :",

            "A. pendiente =  elevación / corrimiento",
            "B. * m= y2 - y1 / x2 – x1 ",
            "C. m= y – y1 /  x – x1 "
        };

        string[] tercerEjercicio =
        {
            //3:R = B. 2/3
            "3. Encuentre la pendiente de la recta que pasa por los puntos P(2,1) y Q(8, 5):",

            "A. 5/3",
            "B. *2/3",
            "C. 7/3"
        };


        string[] cuartoEjercicio =
        {
            //4:R = C. Forma punto – pendiente  E.
            "4. La ecuación de la recta que pasa por el punto (x1, y1) " +
                " y tiene pendiente m se conoce también como :",

            "A. Forma punto – pendiente I.",
            "B. Pendiente de una recta",
            "C. *Forma punto – pendiente  E.  "
        };

        string[] quintoEjercicio =
       {
            //5:R = A. x + 2y + 5 = 0
            "5. Encuentre la ecuación de la recta que paso por (1, -3) con pendiente de  - 1/2 : ",

            "A.  *x + 2y + 5 = 0",
            "B.  2x + y + 5 = 2",
            "C.  2y + 6 = -x + 1"
        };

        #endregion
        public EUnidad7Page()
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
                case 1: //1:R = A. Elevación y corrimiento

                    // click==1 Ya solo verifica lo que se selecciono de la respuesta por que la  vista ya se cargo antes
                    if (checkA.IsChecked == true && checkB.IsChecked == false && checkC.IsChecked == false)
                    {
                        contadorACiertoCorrecto += 1;// 1.Le sumo 1 Pt
                        DisplayAlert("Respuesta", $"Correcta", "Ok");//4.Imprimo mensaje correcta
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

                    // NOTA: Adelanto las el formulario de la PREGUNTA 2  
                    labelPreguntaDescripcion.Text = segundoEjercicio[0];
                    labelRespuestaA.Text = segundoEjercicio[1];
                    labelRespuestaB.Text = segundoEjercicio[2];
                    labelRespuestaC.Text = segundoEjercicio[3];
                    break;

                case 2:   //2:R = B. m= y2 - y1 / x2 – x1 

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


                case 3:  //3:R = B. 2/3 

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
                    //PREGUNTA 4
                    labelPreguntaDescripcion.Text = cuartoEjercicio[0];
                    labelRespuestaA.Text = cuartoEjercicio[1];
                    labelRespuestaB.Text = cuartoEjercicio[2];
                    labelRespuestaC.Text = cuartoEjercicio[3];

                    break;

                case 4:   //4:R = C. Forma punto – pendiente  E.
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

                case 5:   //5:R = A. x + 2y + 5 = 0


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
