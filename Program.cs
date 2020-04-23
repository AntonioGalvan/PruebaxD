using System;

namespace Adivina_el_número
{
    class Program
    {
        static void Main(string[] args)
        {
            byte intento = 0, respuesta;
            int numUsuario = 0;

            do
            {
                Console.WriteLine("          ADIVINA EL NÚMERO \nDebes adivinar el número entre 0 y 100");
                Console.WriteLine("¿Deseas jugar? \n 1-Sí / 2-No");
                try
                {
                    respuesta = byte.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    respuesta = 3;
                }
                
                if (respuesta < 1 || respuesta > 2)
                {
                    Console.WriteLine("Opción no válida");
                }
            } while (respuesta < 1 || respuesta > 2);
            
            while (respuesta == 1)
            {
                intento = 0;
                Random numero = new Random();
                int numAleatorio = numero.Next(0, 100);
                while (numUsuario != numAleatorio)
                {
                    intento++;
                    Console.WriteLine("Dime un número:");
                    try
                    {
                        numUsuario = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Has introducido un dato inválido");
                        numUsuario = 101;
                    }
                    catch (OverflowException e)
                    {
                        Console.WriteLine("Has introducido un número demasiado largo :/");
                        numUsuario = 101;
                    }
                    if (numUsuario > 100 || numUsuario < 0) Console.WriteLine("Tu respuesta no está en el rango");
                    else
                    {
                        if (numUsuario + 90 < numAleatorio) Console.WriteLine("Estás helado, el número es mucho mayor");
                        else if (numUsuario + 60 < numAleatorio) Console.WriteLine("Estás Muy frío, el número es bastante mayor");
                        else if (numUsuario + 40 < numAleatorio) Console.WriteLine("Estás frío, el número es un tanto mayor");
                        else if (numUsuario + 20 < numAleatorio) Console.WriteLine("Estás tíbio, el número es mayor");
                        else if (numUsuario + 10 < numAleatorio) Console.WriteLine("Estás caliente, el número el algo mayor");
                        else if (numUsuario < numAleatorio) Console.WriteLine("Estás hirviendo, el número es un poco mayor");

                        if ((numUsuario - 90) > numAleatorio) Console.WriteLine("Estás helado, el número es mucho menor");
                        else if (numUsuario - 60 > numAleatorio) Console.WriteLine("Estás Muy frío, el número es bastante menor");
                        else if (numUsuario - 40 > numAleatorio) Console.WriteLine("Estás frío, el número es un tanto menor");
                        else if (numUsuario - 20 > numAleatorio) Console.WriteLine("Estás tíbio, el número es menor");
                        else if (numUsuario - 10 > numAleatorio) Console.WriteLine("Estás caliente, el número es algo menor");
                        else if (numUsuario > numAleatorio) Console.WriteLine("Estás hirviendo, el número es un poco menor");
                    }

                }
                Console.WriteLine("Felicidades!, lo has hecho con {0} intentos", intento);
                Console.WriteLine("\n******************************************");
                Console.WriteLine("*                                        *");
                Console.WriteLine("*            ||             ||           *");
                Console.WriteLine("*            ||             ||           *");
                Console.WriteLine("*                                        *");
                Console.WriteLine("*                                        *");
                Console.WriteLine("*                                        *");
                Console.WriteLine("*       *                        *       *");
                Console.WriteLine("*         *                    *         *");
                Console.WriteLine("*           *                *           *");
                Console.WriteLine("*             *            *             *");
                Console.WriteLine("*               **********               *");
                Console.WriteLine("*                                        *");
                Console.WriteLine("******************************************\n");
                Console.WriteLine("¿Deseas jugar de nuevo? \n1-Sí / 2-No");
                respuesta = byte.Parse(Console.ReadLine());
            }
            Console.WriteLine("Hasta pronto :)");
                
        }
    }
}
