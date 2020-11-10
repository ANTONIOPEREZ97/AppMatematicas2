using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MiResidencia20.Views.Ejercicios
{
    public partial class EUnidad9Page : ContentPage
    {
        int contadorACiertoCorrecto = 0;

        #region DefinitionsExcercise
        string[] primerEjercicio =
        {
            //1:R = B. 1
            "1. Evaluar la expresión sen 30˚ csc 30˚ :",

            "A. 5",
            "B. *1",
            "C. 3"
        };

        string[] segundoEjercicio =
        {
              //2:R = A  √3/2
            "2. Evaluar la expresión   sen π/6 + cos π/6 :",

            "A. *√3/2",
            "B.  1",
            "C.  0.8925 "
        };

        string[] tercerEjercicio =
        {
            //3:R = B. 1/2
            "3. Evaluar la expresión    (cos 30˚)²  - (sen 30˚)²",

            "A. 1/5 ",
            "B. *1/2",
            "C. 1/8"
        };


        string[] cuartoEjercicio =
        {
            //4:R = C. sen t
            "4. La expresión trigonométrica cos t tan t es :",

            "A. cos t ",
            "B. csc t ",
            "C. *sen t"
        };

        string[] quintoEjercicio =
       {
            //5:R = B. csc u
            "5. La expresión trigonométrica sen u +  cot u cos u   es: : ",

            "A. tan u ",
            "B. *csc u",
            "C. cot u "
        };

        #endregion
        public EUnidad9Page()
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
                case 1:  //1:R = B. 1

                    // click==1 Ya solo verifica lo que se selecciono de la respuesta por que la  vista ya se cargo antes
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
                            DisplayAlert("Respuesta", $"Incorecta", "Ok"); //4.Imprimo mensaje incorrecta

                        }
                    }

                    // NOTA: Adelanto las el formulario de la PREGUNTA 2  
                    labelPreguntaDescripcion.Text = segundoEjercicio[0];
                    labelRespuestaA.Text = segundoEjercicio[1];
                    labelRespuestaB.Text = segundoEjercicio[2];
                    labelRespuestaC.Text = segundoEjercicio[3];
                    break;

                case 2:    //2:R = A  √3/2

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

                    //PREGUNTA 3
                    labelPreguntaDescripcion.Text = tercerEjercicio[0];
                    labelRespuestaA.Text = tercerEjercicio[1];
                    labelRespuestaB.Text = tercerEjercicio[2];
                    labelRespuestaC.Text = tercerEjercicio[3];

                    break;


                case 3:   //3:R = B. 1/2

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

                case 4:   //C. sen t
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

                case 5:   //5:R = B. csc u


                    if (checkB.IsChecked == true && checkA.IsChecked == false && checkC.IsChecked == false)
                    {
                        DisplayAlert("Respuesta", $"Correcta", "Ok");
                        contadorACiertoCorrecto += 1;

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
