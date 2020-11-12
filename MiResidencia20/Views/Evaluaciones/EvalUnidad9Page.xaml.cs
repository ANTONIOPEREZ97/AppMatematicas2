using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MiResidencia20.Views.Evaluaciones
{
    public partial class EvalUnidad9Page : ContentPage
    {
        int contadorACiertoCorrecto = 0;
        #region DefinitionsEvaluations

        string[] primeraPregunta =
       {
            //1:R =  C. π/3
            "1. Exprese 60˚  en radianes :",

            "A. π/ 6",
            "B. π/4 ",
            "C. *π/3"
        };


        string[] segundaPregunta =
        {
            //2:R = A. -1
            "2. Resuelva la expresión tan²x - sec²x :",

            "A. *-1",
            "B. 1",
            "C. 0"
        };

        string[] terceraPregunta =
        {
            //3:R = A. 1
            "3. Simplifique la  expresión trigonométrica  sen x sec x / tan x : ",

            "A. *1",
            "B. 0",
            "C. -1"
        };

        string[] cuartaPregunta =
        {
            //4:R = C. tan ø   
            "4. Evaluar la expresión sen ø sec ø :",

            "A. sec ø",
            "B. cos ø",
            "C. *tan ø"

        };

        string[] quintaPregunta =
        {
            //5:R = B. cos ø 
            "5. La expresión  tan ø +  cos(-ø) + tan (-ø) es :",

            "A. cot ø",
            "B. *cos ø",
            "C. tan ø"

        };
        #endregion
        public EvalUnidad9Page()
        {
            InitializeComponent();
            CargarPreguntaUno();
        }

        public void CargarPreguntaUno()
        {
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
                case 1:     //1:R =  C. π/3

                    // click==1 Ya solo verifica lo que se seleccionó de la respuesta por que la  vista ya se cargo
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
                            DisplayAlert("Respuesta", $"Incorrecta", "Ok"); //4.Imprimo mensaje incorrecta
                        }
                    }

                    // NOTA: Adelanto las el formulario de la PREGUNTA 2  
                    labelPreguntaDescripcion.Text = segundaPregunta[0];
                    labelRespuestaA.Text = segundaPregunta[1];
                    labelRespuestaB.Text = segundaPregunta[2];
                    labelRespuestaC.Text = segundaPregunta[3];
                    break;

                case 2:   //2:R = A. -1

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
                    labelPreguntaDescripcion.Text = terceraPregunta[0];
                    labelRespuestaA.Text = terceraPregunta[1];
                    labelRespuestaB.Text = terceraPregunta[2];
                    labelRespuestaC.Text = terceraPregunta[3];

                    break;


                case 3:   //3:R = A. 1

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
                    //PREGUNTA 4
                    labelPreguntaDescripcion.Text = cuartaPregunta[0];
                    labelRespuestaA.Text = cuartaPregunta[1];
                    labelRespuestaB.Text = cuartaPregunta[2];
                    labelRespuestaC.Text = cuartaPregunta[3];

                    break;

                case 4:   //4:R = C. tan ø  

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
                    labelPreguntaDescripcion.Text = quintaPregunta[0];
                    labelRespuestaA.Text = quintaPregunta[1];
                    labelRespuestaB.Text = quintaPregunta[2];
                    labelRespuestaC.Text = quintaPregunta[3];

                    break;

                case 5:  //5:R = B. cos ø 

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
        #endregion Methods
    }
}
