using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MiResidencia20.Views.Evaluaciones
{
    public partial class EvalUnidad2Page : ContentPage
    {
        int contadorACiertoCorrecto = 0;
        #region DefinitionsEvaluations
        string[] primeraPregunta =
       {
            //1:R = B. x^14
            "1. Simplifique la expresión  x¹²x² :",

            "A. 2xˆ14",
            "B. *xˆ14",
            "C. xˆ24"
        };


        string[] segundaPregunta =
        {

            //2:R = B. 3y^6/z 
            "2. Simplifique la expresión 6y⁷z/2yz²:",
            "A. 4yˆ8 z  ",
            "B. *3yˆ6/z",
            "C. 3yˆ6/-z"
        };

        string[] terceraPregunta =
        {
            //3:R = C. 128y^14
            "3. Simplifique la expresion (2y²)⁷ : ",
            "A. 2 yˆ14",
            "B. 28 y",
            "C. *128yˆ14"
        };

        string[] cuartaPregunta =
        {
            //4:R = C. 8x^19 y^3
            "4. Simplifique la expresión (4x¹²y²) (2x⁷y) :",
            "A. 4,032 xy",
            "B. 288xˆ5 y",
            "C. *8xˆ19 yˆ3"

        };

        string[] quintaPregunta =
        {
            //5:R = A. 32000000 
            "5. La expresión 3.20 X 10⁷ en notación decimal es :",
            "A. *32000000",
            "B. 320000000",
            "C. 3200000000"

        };
        #endregion

        public EvalUnidad2Page()
        {
            InitializeComponent();
            CargarPreguntaUno();
        }

        public void CargarPreguntaUno()
        {
            //1:R = B. x^14
            //Enlazo Xaml con array del Cs
            labelPreguntaDescripcion.Text = primeraPregunta[0];
            labelRespuestaA.Text = primeraPregunta[1];
            labelRespuestaB.Text = primeraPregunta[2];
            labelRespuestaC.Text = primeraPregunta[3];

        }

        int contadorClicks = 1;
        void Btn_siguiente(System.Object sender, System.EventArgs e)
        {
            #region SwitchExcersice
            switch (contadorClicks)
            {
                case 1:     //1:R = B. x^14

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
                    labelPreguntaDescripcion.Text = segundaPregunta[0];
                    labelRespuestaA.Text = segundaPregunta[1];
                    labelRespuestaB.Text = segundaPregunta[2];
                    labelRespuestaC.Text = segundaPregunta[3];
                    break;

                case 2:   //2:R = B. 3y^6/z 

                    if (checkB.IsChecked == true && checkA.IsChecked == false && checkC.IsChecked == false)
                    {
                        contadorACiertoCorrecto += 1;
                        DisplayAlert("Respuesta", $"Correcta", "Ok");

                    }

                    else
                    {
                        if ( checkA.IsChecked == false && checkB.IsChecked == false && checkC.IsChecked == false ||
                             checkB.IsChecked == true && checkA.IsChecked == true ||
                             checkB.IsChecked == true && checkC.IsChecked == true ||
                             checkA.IsChecked == true || checkC.IsChecked == true)
                        {
                            contadorACiertoCorrecto += 0;//1. Le sumo 0 pts
                            DisplayAlert("Respuesta", $"Incorrecta", "Ok"); //4.Imprimo mensaje incorrecta
                        }
                    }

                    //PREGUNTA 3
                    labelPreguntaDescripcion.Text = terceraPregunta[0];
                    labelRespuestaA.Text = terceraPregunta[1];
                    labelRespuestaB.Text = terceraPregunta[2];
                    labelRespuestaC.Text = terceraPregunta[3];

                    break;


                case 3: //3:R = C. 128y^14

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
                            DisplayAlert("Respuesta", $"Incorrecta", "Ok"); //4.Imprimo mensaje incorrecta
                        }
                    }
                    //PREGUNTA 4
                    labelPreguntaDescripcion.Text = cuartaPregunta[0];
                    labelRespuestaA.Text = cuartaPregunta[1];
                    labelRespuestaB.Text = cuartaPregunta[2];
                    labelRespuestaC.Text = cuartaPregunta[3];

                    break;

                case 4:  //4:R = C. 8x^19 y^3

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
                            DisplayAlert("Respuesta", $"Incorrecta", "Ok"); //4.Imprimo mensaje incorrecta
                        }
                    }

                    //PREGUNTA 5
                    labelPreguntaDescripcion.Text = quintaPregunta[0];
                    labelRespuestaA.Text = quintaPregunta[1];
                    labelRespuestaB.Text = quintaPregunta[2];
                    labelRespuestaC.Text = quintaPregunta[3];

                    break;

                case 5:  //5:R = A. 32000000 

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
                            DisplayAlert("Respuesta", $"Incorrecta", "Ok"); //4.Imprimo mensaje incorrecta
                        }
                    }
                    break;

                case 6: //Mostrar Calificación de Acierto 1*20%
                    var calificacionPorcentaje = contadorACiertoCorrecto * 20;

                    if (calificacionPorcentaje >= 80)
                    {
                        DisplayAlert("CALIFICACIÓN", $"{calificacionPorcentaje}% , Felicitaciones!", "Ok");
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
        #endregion 
    }
}
