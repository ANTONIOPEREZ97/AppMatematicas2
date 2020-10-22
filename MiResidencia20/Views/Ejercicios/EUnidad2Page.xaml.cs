﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MiResidencia20.Views.Ejercicios
{
    public partial class EUnidad2Page : ContentPage
    {
        int contadorACiertoCorrecto = 0;

        #region DefinitionsExcercise
        //Básicos 1/3 | Frame.BackgroundColor="#C4ECE7" 
        string[] primerEjercicio =
        {
              //1:R = A. Sumar los exponentes
            "1. Para multiplicar dos potencias del mismo número es suficiente:",

            "A. *Sumar los exponentes",
            "B. Restar los exponentes",
            "C. Multiplicar los exponentes"
        };

        string[] segundoEjercicio =
        {
              //2:R = B. Restar los exponentes
            "2. Para dividir dos pontencias del mismo número es suficiente:",

            "A. Sumar los exponentes",
            "B. *Restar los exponentes",
            "C. Multiplicar los exponentes"


        };

        string[] tercerEjercicio =
        {
            //3:R = C. Multiplicar los exponentes
            "3. Para elevar una  potencia a una nueva potencia es suficiente:",
            "A. Sumar los exponentes",
            "B. Restar los exponentes",
            "C. *Multiplicar los exponentes"
        };


        //Ejercicio Intermedio 4/6 | Frame.BorderColor="#B0CFF4 "
        string[] cuartoEjercicio =
        {
            //4:R = B.La raíz positiva
            "4. El símbolo √ signfica:",

            "A. La raíz negativa",
            "B. *La raíz positiva",
            "C. Asociativa",
        };


        string[] quintoEjercicio =
       {
            //5:R = C. Ninguno de los anteriores
            "5. La raíz  cuarta  de √-16 es: ",

            "A. 4",
            "B. 8",
            "C. *Ninguno de los anteriores"

        };

        #endregion
        public EUnidad2Page()
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
                case 1:  //1:R = A. Sumar los exponentes

                    // click==1 Ya solo verifica lo que se selecciono de la respuesta por que la  vista ya se cargo
                    if (checkA.IsChecked == true)
                    {
                        contadorACiertoCorrecto += 1;// 1.Le sumo 1 Pt
                        DisplayAlert("Acierto", $"Correcta", "Ok");//4.Imprimo mensaje correcta
                    }
                    else
                    {
                        contadorACiertoCorrecto += 0;//1. Le sumo 0 pts
                        DisplayAlert("Respuesta", $"Incorecta", "Ok"); //4.Imprimo mensaje incorrecta
                    }

                    // NOTA: Adelanto las el formulario de la PREGUNTA 2  
                    labelPreguntaDescripcion.Text = segundoEjercicio[0];
                    labelRespuestaA.Text = segundoEjercicio[1];
                    labelRespuestaB.Text = segundoEjercicio[2];
                    labelRespuestaC.Text = segundoEjercicio[3];
                    break;

                case 2: //2:R = B. Restar los exponentes

                    if (checkB.IsChecked == true)
                    {
                        contadorACiertoCorrecto += 1;
                        DisplayAlert("Acierto", $"Correcta", "Ok");

                    }
                    else
                    {
                        contadorACiertoCorrecto += 0;
                        DisplayAlert("Respuesta", $"Incorecta", "Ok");
                    }

                    //PREGUNTA 3
                    labelPreguntaDescripcion.Text = tercerEjercicio[0];
                    labelRespuestaA.Text = tercerEjercicio[1];
                    labelRespuestaB.Text = tercerEjercicio[2];
                    labelRespuestaC.Text = tercerEjercicio[3];

                    break;


                case 3:   //3:R = C. Multiplicar los exponentes

                    if (checkC.IsChecked == true)
                    {
                        contadorACiertoCorrecto += 1;
                        DisplayAlert("Acierto", $"Correcta", "Ok");
                    }
                    else
                    {
                            contadorACiertoCorrecto += 0;
                            DisplayAlert("Respuesta", $"Incorecta", "Ok");
                    }

                    //PREGUNTA 4
                    labelPreguntaDescripcion.Text = cuartoEjercicio[0];
                    labelRespuestaA.Text = cuartoEjercicio[1];
                    labelRespuestaB.Text = cuartoEjercicio[2];
                    labelRespuestaC.Text = cuartoEjercicio[3];

                    break;

                case 4:  //4:R = B.La raíz positiva

                    if (checkB.IsChecked == true)
                    {
                        contadorACiertoCorrecto += 1;
                        DisplayAlert("Acierto", $"Correcta", "Ok");
                    }
                    else
                    {
                        contadorACiertoCorrecto += 0;
                        DisplayAlert("Respuesta", $"Incorecta", "Ok");
                    }

                    //PREGUNTA 5
                    labelPreguntaDescripcion.Text = quintoEjercicio[0];
                    labelRespuestaA.Text = quintoEjercicio[1];
                    labelRespuestaB.Text = quintoEjercicio[2];
                    labelRespuestaC.Text = quintoEjercicio[3];

                    break;

                case 5:   //5:R = C. Ninguno de los anteriores

                    if (checkA.IsChecked == true)
                    {
                        DisplayAlert("Acierto", $"Correcta", "Ok");
                        contadorACiertoCorrecto += 1;
                    }
                    else
                    {
                        DisplayAlert("Respuesta", $"Incorecta", "Ok");
                        contadorACiertoCorrecto += 0;
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

        /* !!!! NO SE NECESITA UN METODO LIMPIAR PREGUNTA SE PUEDE QUITAR!!!!
        public void LimpiarFormularioDePreguntas()
        {
            labelPreguntaDescripcion.Text = string.Empty;
            labelRespuestaA.Text = string.Empty;
            labelRespuestaB.Text = string.Empty;
            labelRespuestaC.Text = string.Empty;
        }
        */

        public void LimpiarChecks()
        {
            checkA.IsChecked = false;
            checkB.IsChecked = false;
            checkC.IsChecked = false;

        }
        #endregion Methods
    }
}
