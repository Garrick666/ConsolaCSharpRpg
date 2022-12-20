using ConsoleApp1.Clases;
using ConsoleApp1.MotorJuego;
using Newtonsoft.Json;
using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        private static ServicioJuego serviciojuego = new ServicioJuego();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MuestraTitulo();
            MuestraMenu();
            
        }

        

        private static void MuestraTitulo()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("*****************************");
            Console.WriteLine("         RPG CONSOLA     ");
            Console.WriteLine("*****************************");


        }

        private static void MuestraMenu()
        {
            bool opcionValida = false;

            while (opcionValida == false)
            {
                Console.WriteLine("[1] - Nuevo Juego");
                Console.WriteLine("[2] - Cargar Juego");
                Console.WriteLine("[3] - Opciones");
                Console.WriteLine("[4] - Salir");

                string respUsuario = Console.ReadLine();

                int resultado = Convert.ToInt32(respUsuario);
                

                switch (resultado)
                {
                    case 1:
                        Console.WriteLine("Opción 1 valida");
                        opcionValida = true;
                        serviciojuego.NuevoJuego();
                        break;

                    case 2:
                        Console.WriteLine("Opción 2 valida");
                        opcionValida = true;
                        break;

                    case 3:
                        Console.WriteLine("Opción 3 valida");
                        opcionValida = true;
                        break;

                    case 4:
                        Console.WriteLine("Opción 4 valida");
                        opcionValida = true;
                        break;

                    default:
                        Console.WriteLine("Opción NO valida");
                        break;
                }
            }

        }

        

        private static void CargarJuego()
        {

        }

        private static void Opciones()
        { 
        
        }




        private static int ConvertirTextoAEntero(string texto) {
            return Convert.ToInt32(texto);
        }
    }
}