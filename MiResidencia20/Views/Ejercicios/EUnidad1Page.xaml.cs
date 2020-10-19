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

        //Básicos 1/3 | Frame.BackgroundColor="#C4ECE7" 
        string[] primerEjercicio=
        {
              //1:R = B. Números naturales
            "1.Son aquellos que no necesitan representarse como una fracción o un decimal." +
            " Además no pueden ser negativos:",

            "A. Números irracionales",
            "B.*Números naturales",
            "C. Números enteros"
        };

        string[] segundoEjercicio =
        {
              //2:R = A. Números enteros
            "2. Son números naturales, pero también pueden ser negativos:",
            "A. *Números enteros",
            "B. Números irracionales",
            "C. Números naturales"
        };

        string[] tercerEjercicio =
        {
            //3:R = C. Números irracionales
            "3.Son aquellos que no pueden expresarse como la fracción de dos enteros:",
            "A. Números enteros",
            "B. Números naturales",
            "C. *Números irracionales"
        };


        //Ejercicio Intermedio 4/6 | Frame.BorderColor="#B0CFF4 "
        string[] cuartoEjercicio =
        {
            //4:R = A.Conmutativa
            "4. Propiedad de los números reales que cuando sumamos o multiplicamos dos números, " +
            "el orden no importa; A+B=B+A, AB=BA:",

            "A. *Conmutatativa",
            "B. Distributiva",
            "C. Asociativa",
        };


        string[] quintoEjercicio =
       {
            //5:R = A. Asociativa
            "5.Propiedad de los números reales que cuando sumamos o multiplicamos tres números, " +
            "no importa cuales dos de ellos sumamos o multiplicamos prirmero; (A+B)+C=A+(B+C), (AB)C=A(BC)",

            "A. *Asociativa",
            "B. Conmutatativa",
            "C. Distributiva"

        };

        string[] sextoEjercicio =
       {
            //6:R = C. Distributiva
            "6.Propiedad de los números reales que cuando multiplicamos un número por una suma de dos números" +
              " obtenemos el mismo resultado si multiplicamos el número por cada uno de los términos" +
              "y luego sumamos los resultados; A(B+C)=AB+AC,(B+C)A=AB+AC:",
                             
            "A. Conmutatativa",
            "B. Asociativa",
            "C. *Distributiva"
        };



        //Ejercicio Avanzado 7/10 | Frame.BorderColor="#F99F8A "

        string[] septimoEjercicio =
        {
            //7:R = A. Verdadero
            "7.Verficar si  la desigualdad es verdadero o falsa 8 < 9 : ",
            "A. *Verdadero",
            "B. Falso"
        };

        string[] octavoEjercicio =
        {
            //8:R = B. Falso 
            "8.Verficar si  la desigualdad es verdadero o falsa  √2 > 1.41:",
            "A. Verdadero",
            "B. *Falso"
        };

        string[] novenoEjercicio = 
        {
            //9:R = B. Falso
            "9.Verficar si  la desigualdad es verdadero o falsa -1/2 < -1 : ",
            "A. Verdadero",
            "B. *Falso"
        };

        string[] decimoEjercicio =
        {
            //10:R = A. Verdadero
            "10.Verficar si  la desigualdad es verdadero o falsa -π > -3:",
            "A. *Verdadero",
            "B. Falso"
        };

        public  EUnidad1Page()
        {
  
            InitializeComponent();

        }

        
        int contadorClicks = 0;
        void   Btn_siguiente(System.Object sender, System.EventArgs e)
        {
            
            switch (contadorClicks)

            {
                case 0:
                    DisplayAlert("Ejercicios ", "Básico,Intermedio y Avanzado", "ok");
                    break;

                case 1:  //1:R = B. Números naturales

                    //Enlazo Xaml con array del Cs
                    labelPreguntaDescripcion.Text = primerEjercicio[0];
                    labelRespuestaA.Text = primerEjercicio[1];
                    labelRespuestaB.Text = primerEjercicio[2];
                    labelRespuestaC.Text = primerEjercicio[3];

                    if (checkB.IsChecked == true)
                    {
                        contadorACiertoCorrecto += 1;// 1.Le sumo 1 Pt
                        DisplayAlert("Acierto", $"Correcta", "Ok");//4.Imprimo mensaje correcta
                    }
                    else
                    {
                        contadorACiertoCorrecto += 0;//1. Le sumo 0 pts
                        DisplayAlert("Respuesta", $"Incorecta", "Ok"); //4.Imprimo mensaje incorrecta
                    }

                    //LimpiarFormularioDePreguntas();
                    break;



                case 2: //2:R = A. Números enteros

                    labelPreguntaDescripcion.Text = segundoEjercicio[0];
                    labelRespuestaA.Text = segundoEjercicio[1];
                    labelRespuestaB.Text = segundoEjercicio[2];
                    labelRespuestaC.Text = segundoEjercicio[3];

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
                    break;



                case 3: //3:R = C. Números irracionales

                    labelPreguntaDescripcion.Text = tercerEjercicio[0];
                    labelRespuestaA.Text = tercerEjercicio[1];
                    labelRespuestaB.Text = tercerEjercicio[2];
                    labelRespuestaC.Text = tercerEjercicio[3];

                    if (checkC.IsChecked == true)
                    {
                        contadorACiertoCorrecto += 1;
                        DisplayAlert("Acierto", $"Correcta", "Ok");
                    }
                    else
                    {
                        contadorACiertoCorrecto += 0;
                        DisplayAlert("Respuesta", $"Incorecta", "Ok");                    }
                    break;


                case 4:  //4:R = A.Conmutativa

                    labelPreguntaDescripcion.Text = cuartoEjercicio[0];
                    labelRespuestaA.Text = cuartoEjercicio[1];
                    labelRespuestaB.Text = cuartoEjercicio[2];
                    labelRespuestaC.Text = cuartoEjercicio[3];

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
                    break;



                case 5: //5:R = A. Asociativa

                    labelPreguntaDescripcion.Text = quintoEjercicio[0];
                    labelRespuestaA.Text = quintoEjercicio[1];
                    labelRespuestaB.Text = quintoEjercicio[2];
                    labelRespuestaC.Text = quintoEjercicio[3];

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
                    break;

                case 6:  //6:R = C. Distributiva

                    labelPreguntaDescripcion.Text = sextoEjercicio[0];
                    labelRespuestaA.Text = sextoEjercicio[1];
                    labelRespuestaB.Text = sextoEjercicio[2];
                    labelRespuestaC.Text = sextoEjercicio[3];

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
                    break;



                case 7: //7:R = A. Verdadero

                    labelPreguntaDescripcion.Text = septimoEjercicio[0];
                    labelRespuestaA.Text = septimoEjercicio[1];
                    labelRespuestaB.Text = septimoEjercicio[2];

                    //1.Nueva implementación: Deshabilito checkC y labelRespuestaC ya que no los uso
                    //checkC.IsVisible = false;
                    //labelRespuestaC.IsVisible = false;

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
                    break;

                case 8: //8:R = B. Falso 

                    labelPreguntaDescripcion.Text = octavoEjercicio[0];
                    labelRespuestaA.Text = octavoEjercicio[1];
                    labelRespuestaB.Text = octavoEjercicio[2];

                    //checkC.IsVisible = false;
                    //labelRespuestaC.IsVisible = false;

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
                    break;

                case 9: //9:R = B. Falso

                    labelPreguntaDescripcion.Text = novenoEjercicio[0];
                    labelRespuestaA.Text = novenoEjercicio[1];
                    labelRespuestaB.Text = novenoEjercicio[2];
                    
                    //checkC.IsVisible = false;
                    //labelRespuestaC.IsVisible = false;

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
                    break;

                case 10:  //10:R = A. Verdadero

                    labelPreguntaDescripcion.Text = decimoEjercicio[0];
                    labelRespuestaA.Text = decimoEjercicio[1];
                    labelRespuestaB.Text = decimoEjercicio[2];

                    //checkC.IsVisible = false;
                    //labelRespuestaC.IsVisible = false;

                    if (checkA.IsChecked == true)
                    {
                        contadorACiertoCorrecto += 1;
                        DisplayAlert("Acierto", $"Correcta", "Ok");
                        //Nueva implementación 
                        DisplayAlert("Califición", $"{contadorACiertoCorrecto}%", "Ok");
                    }
                    else
                    {
                        contadorACiertoCorrecto += 0;
                        DisplayAlert("Respuesta", $"Incorecta", "Ok");
                        DisplayAlert("Califición", $"{contadorACiertoCorrecto}%", "Ok");
                    }
                    break;

            }
            LimpiarChecks();
            contadorClicks++;
            

        }//fin Boton


        #region Methods
        public void LimpiarFormularioDePreguntas()
        {
            labelPreguntaDescripcion.Text = string.Empty;
            labelRespuestaA.Text = string.Empty;
            labelRespuestaB.Text = string.Empty;
            labelRespuestaC.Text = string.Empty;
        }

        public void LimpiarChecks()
        {
            checkA.IsChecked = false;
            checkB.IsChecked = false;
            checkC.IsChecked = false;

        }
        #endregion Methods

    }

}
    

