using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MiResidencia20.Views.Ejercicios
{
    public partial class EUnidad4Page : ContentPage
    {
        int contadorACiertoCorrecto = 0;
        #region DefinitionsExcercise
        //Básicos 1/3 | Frame.BackgroundColor="#C4ECE7" 
        string[] primerEjercicio =
        {
              //1:R = A.Verdadero
            "1. Sumar el mismo número a cada lado de una ecuación siempre da una ecuación equivalente:",

            "A. *Verdadero",
            "B. Falso",
            "C. Ninguno de los anteriores"
        };

        string[] segundoEjercicio =
        {
              //2:R = A.Verdadero
            "2. Multiplicar cada lado de una ecuación por el mismo número siempre da una ecuación equivalente:",

            "A. *Verdadero",
            "B. Falso",
            "C. Ninguno de los anteriores"

        };

        string[] tercerEjercicio =
        {
            //3:R = A. Verdadero
            "3. Elevar al cuadrado cada lado de una ecuación siempre da una ecuación equivalente: ",

            "A. *Verdadero",
            "B. Falso",
            "C. Ninguno de los anteriores"
        };


        //Ejercicio Intermedio 4/6 | Frame.BorderColor="#B0CFF4 "
        string[] cuartoEjercicio =
        {
            //4:R = B. Ecuación cuadrática
            "4. La ecuación  ax² + bx + c = 0 tiene la forma de una: ",

            "A. Ecuación no lineal",
            "B. Ecuación  cuadrática",
            "C. Ecuación lineal"
        };


        string[] quintoEjercicio =
       {
            //5:R = A. a²  - 2ab  + b²
            "5. El resultado de  (a - b)²  es: ",

            "A. *a² - 2ab + b²",
            "B. a² + 2ab + b²",
            "C. a² - b²"
        };

        #endregion
        public EUnidad4Page()
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
                case 1:  //1:R = A.Verdadero

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

                case 2: //2:R = A.Verdadero

                    if (checkA.IsChecked == true)
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


                case 3:  //2:R = A.Verdadero

                    if (checkA.IsChecked == true)
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

                case 4:  //4:R = B. Ecuación cuadrática

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

                case 5:  //5:R = A. a² - 2ab + b²

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
