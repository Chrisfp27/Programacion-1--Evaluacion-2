using System;

namespace Evaluacion_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;
            double altura = 0;
            string cadena = "";

            Console.WriteLine("Bienvenido a FunWorld, por favor ingrese su edad a continuación");
            cadena = Console.ReadLine();
            edad = Convert.ToInt32(cadena);

            if (edad <= 17)
            {
            Console.WriteLine("Lo siento, para entrar a FunWorld debes ser mayor de edad");
            }
            
            else 
           {
            Console.WriteLine("¡Bienvenido, le deseamos que la pase de la mejor manera aqui en FunWorld!");
            Console.WriteLine("Para brindar una mayor seguridad dentro de las instalaciones, por favor introduzca su altura.");
            cadena = Console.ReadLine();
            altura = Convert.ToDouble(cadena);
           

            if (altura <= 1.64)
            {
            Console.WriteLine("Por su seguridad, podra entrar a la casa de los encantos, al área de feria y a la montaña del dragón.");
            Console.WriteLine("¡Le deseamos que tenga un día maravilloso aqui en FunWorld!");
            }

            else
            {

            Console.WriteLine("Felicitaciones, usted puede entrar a todas las áreas y atraccciones que estan abiertas al público.");
            Console.WriteLine("¡Le deseamos que tenga un día maravilloso aqui en FunWorld!");
            }
           }


            





        


            
    
            

        }
    }
}
