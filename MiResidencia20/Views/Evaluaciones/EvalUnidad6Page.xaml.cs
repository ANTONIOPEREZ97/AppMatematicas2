using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MiResidencia20.Views.Evaluaciones
{
    public partial class EvalUnidad6Page : ContentPage
    {
        int contadorACiertoCorrecto = 0;
        #region DefinitionsEvaluations

        string[] primeraPregunta =
       {
            //1:R = A. 3/4 s
            "1. Expresar en variable*. La distancia (en millas) que un auto recorre en 45 min; " +
                "s= rapidez del auto (en mi/h) :",

            "A. *3/4 s",
            "B. 1/2 s ",
            "C. 3/5 s"
        };


        string[] segundaPregunta =
        {
            //2:R = A. 3n + 3
            "2. Expresar en variable*. La suma de los tres enteros consecutivos; " +
                "n = primer  entero de los tres :",

            "A. *3n + 3 ",
            "B. 3(3n) + 3",
            "C. 3 + n"
        };

        string[] terceraPregunta =
        {
            //3:R = B. $7,400 
            "3. Una ejecutiva de una compañía de ingeniería gana un salario mensual más un bono de Navidad de $8500. " +
                "Si ella gana un total de $97,300, ¿cuál es su salario mensual? ",

            "A. $6,400",
            "B. *$7,400",
            "C. $7,350"
        };

        string[] cuartaPregunta =
        {
            //4:R = C. l w
            "4. Fórmula para el área de la figura geométrica,  un rectángulo de longitud l y ancho w :",

            "A. 4(l w)",
            "B. l w²",
            "C. *l w"

        };

        string[] quintaPregunta =
        {
            //5:R = A. r = d/t
            "5. De la fórmula d = rt,  despeje r : ",

            "A. *r = d/t",
            "B. r = dt",
            "C. r = t/d"

        };
        #endregion
        public EvalUnidad6Page()
        {
            InitializeComponent();
            CargarPreguntaUno();

        }

        public void CargarPreguntaUno()
        {
            //1:R = A. 3/4 s
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
                case 1:  //1:R = A. 3/4 s

                    // click==1 Ya solo verifica lo que se seleccionó de la respuesta por que la  vista ya se cargo
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
                            DisplayAlert("Respuesta", $"Incorrecta", "Ok"); //4.Imprimo mensaje incorrecta
                        }
                    }

                    // NOTA: Adelanto las el formulario de la PREGUNTA 2  
                    labelPreguntaDescripcion.Text = segundaPregunta[0];
                    labelRespuestaA.Text = segundaPregunta[1];
                    labelRespuestaB.Text = segundaPregunta[2];
                    labelRespuestaC.Text = segundaPregunta[3];
                    break;

                case 2:   //2:R = A. 3n + 3

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


                case 3:  //3:R = B. $7,400 

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
                            DisplayAlert("Respuesta", $"Incorrecta", "Ok"); //4.Imprimo mensaje incorrecta
                        }
                    }
                    //PREGUNTA 4
                    labelPreguntaDescripcion.Text = cuartaPregunta[0];
                    labelRespuestaA.Text = cuartaPregunta[1];
                    labelRespuestaB.Text = cuartaPregunta[2];
                    labelRespuestaC.Text = cuartaPregunta[3];

                    break;

                case 4:  //4:R = C. l w

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

                case 5:   //5:R = A. r = d/t

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
        #endregion Methods


    }
}
