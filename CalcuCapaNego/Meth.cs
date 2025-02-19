using CalcCapaDatos;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalcuCapaNego
{
    public class Meth

    {
        public Meth()
        {
            
        }
        public double numero1;
        public double numero2;

        public void CalculadoraMeh(int opcion  , double numero1 , double numero2 )

        {
           
            Datos datos = new Datos();


                switch (opcion)
                {

                    case 1:

                        // llamar a el methodo sumar 

                        datos.sumar( numero1, numero2);
                        break;
                    case 2:
                        // llamar  a el methodo restar 
                        datos.restar(numero1 , numero2);
                        break;
                    case 3:
                        //llamar a el methodo multiplicar 
                        datos.multiplicar( numero1 , numero2);
                        break;
                    case 4:
                        // llamar el methodo devidir
                        datos.dividir(numero1 , numero2);
                        break;

                    default:
                        // si el usuario elije una respuesta que no este dentro 
                        Console.WriteLine("elija una opcion del 1 al 4 ");
                        break;


                }

            }



        }
    }

