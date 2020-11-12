using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MiResidencia20.Views.Evaluaciones
{
    public partial class EvalUnidad4Page : ContentPage
    {
        int contadorACiertoCorrecto = 0;
        #region DefinitionsEvaluations

        string[] primeraPregunta =
       {
            //1:R = B. Expresión fraccionaria 
            "1. El cociente de dos expresiones algebraicas se denomina :",

            "A.  Expresión racional",
            "B. *Expresión fraccionaria",
            "C.  Expresión irracional "
        };


        string[] segundaPregunta =
        {
            //2:R = A. Polinomios
            "2.	Una expresión racional es una expresión fraccionaria donde " +
                "el numerador y el denominador son :",

            "A. *Polinomios",
            "B. Monomios",
            "C. Binomios conjugados"
        };

        string[] terceraPregunta =
        {
            //3:R = C. X ϵ R 
            "3. Encuentre el dominio de la expresión 4x² - 10x +  3 :",

            "A. x ∉ R",
            "B. x ϵ N",
            "C. *x ϵ R "
        };

        string[] cuartaPregunta =
        {
            //4:R = A. x + 2 / x² 
            "4. Simplifique la expresión 1/x+2 / 2x² :",

            "A. *x + 2 / x²",
            "B. 3/x²",
            "C. 3/x³"

        };

        string[] quintaPregunta =
        {
            //5:R = B. x/yz
            "5. Simplifique la expresión x/y / z :",

            "A. y / zx",
            "B. *x / yz",
            "C. zx / y"

        };
        #endregion
        public EvalUnidad4Page()
        {
            InitializeComponent();
            CargarPreguntaUno();
        }

        public void CargarPreguntaUno()
        {
            //1:R = B. Expresión fraccionaria 
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
                case 1: //1:R = B. Expresión fraccionaria 

                    // click==1 Ya solo verifica lo que se seleccionó de la respuesta por que la  vista ya se cargo
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

                case 2:  //2:R = A. Polinomios

                    if (checkA.IsChecked == true && checkB.IsChecked == false && checkC.IsChecked == false)
                    {
                        contadorACiertoCorrecto += 1;
                        DisplayAlert("Respuesta", $"Correcta", "Ok");

                    }

                    else
                    {
                        if  (checkA.IsChecked == false && checkB.IsChecked == false && checkC.IsChecked == false ||
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


                case 3: //3:R = C. X ϵ R 

                    if (checkC.IsChecked == true && checkA.IsChecked == false && checkB.IsChecked == false)
                    {
                        contadorACiertoCorrecto += 1;
                        DisplayAlert("Respuesta", $"Correcta", "Ok");
                    }

                    else
                    {
                        if  (checkA.IsChecked == false && checkB.IsChecked == false && checkC.IsChecked == false ||
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

                case 4: //4:R = A. x + 2 / x² 

                    if (checkA.IsChecked == true && checkB.IsChecked == false && checkC.IsChecked == false)
                    {
                        contadorACiertoCorrecto += 1;
                        DisplayAlert("Respuesta", $"Correcta", "Ok");
                    }
                    else
                    {
                        if  (checkA.IsChecked == false && checkB.IsChecked == false && checkC.IsChecked == false ||
                             checkA.IsChecked == true && checkB.IsChecked == true ||
                             checkA.IsChecked == true && checkC.IsChecked == true ||
                             checkB.IsChecked == true || checkC.IsChecked == true)
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

                case 5:   //5:R = B. x/yz

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
