namespace CalcCapaDatos
{
    public class Datos
    {

        public Datos() { }

        public void sumar(double numero1, double numero2)
        {
            if ((numero1 > 0 )&& (numero2 >0))
            {
                double suma = numero1 + numero2;

                Console.WriteLine("la suma es " + suma);
            }
            else if (numero2 <= 0)
            {
                Console.WriteLine("el numero deve de ser mayor que cero ");
            }
        }

        public void restar(double numero1, double numero2)
        {

            if ((numero1 > 0) && (numero2 > 0))
            {
                double Resta = numero1 - numero2;
                Console.WriteLine("la resta es " + Resta);
            }
            else 
            {
                Console.WriteLine("el numero deve de ser mayor a cero ");
            }

        }
        public void multiplicar(double numero1, double numero2)
        {
            if (( numero1 > 0 ) && (numero2 > 0))
            {
                double multiplicar = numero1 * numero2;
                Console.WriteLine("la multiplicacion es " + multiplicar);
            }
            else 
            {
                Console.WriteLine("el numero deve de ser mayor a cero ");
            }
        }
        public void dividir(double numero1, double numero2)
        {
            if((numero1 > 0) && (numero2 > 0))
            {
                double dividir=numero1 / numero2;
                Console.WriteLine("La divicion es  " +dividir);

            }else
            {
                Console.WriteLine("el numero deve ser mayor a cero ");
            }

        }
    }
}
