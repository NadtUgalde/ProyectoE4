﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoE4
{
    internal class Program
    {
        public static int[] vehiculos = new int[15];
        public static int[] tipoVehiculo = new int[15];
        public static int[] caseta = new int[15];
        public static int[] pago = new int[15];

        static void Main(string[] args)
        {
            menu();
        }

        private static void menu()
        {
            {
                string opcion;

                Console.WriteLine("\tPrograma para controlar peaje de autopista");

                do
                {
                    Console.WriteLine("Desea continuar..(s/n)");
                    opcion = Console.ReadLine();

                    Console.WriteLine("1- Inicializar Vectores");
                    Console.WriteLine("2- Ingresar Paso Vehicular");
                    Console.WriteLine("3- Consulta de vehículos x Número de Placa");
                    Console.WriteLine("4- Modificar Datos Vehículos x número de Placa");
                    Console.WriteLine("5- Reporte Todos los Datos de los vectores");
                    Console.WriteLine("6- Salir");
                    Console.WriteLine("Digite la opcion que desea realizar: ");
                    opcion = Console.ReadLine().ToLower();

                    switch (opcion)
                    {
                        case "1": break;
                        case "2": break;
                        case "3": Consulta(); break;
                        case "4": Modificar(); break;
                        //case "5": Reporte(); break;
                        case "6": break;
                        default:
                            Console.WriteLine("Opcion no es valida!!");
                            break;
                    }

                } while (opcion.Equals("s"));
                Console.ReadLine();


            }
        }

        public static void Consulta()
        {
            int numPlaca;
            Boolean Existe = false;
            Console.WriteLine("Digite el numero de placa que desea consultar: ");
            numPlaca = int.Parse(Console.ReadLine());

            for (int i = 0; i < 15; i++)
            {
                if (vehiculos[i].Equals(numPlaca))
                {
                    Console.Clear();

                    Console.WriteLine();
                    Existe = true;
                    break;
                }

            }
            if (Existe == false)
            {
                Console.Clear();
                Console.WriteLine("Placa no existe");
            }

            Console.Read();
        }

        public static void Modificar()
        {
            int numPlaca;
            int montoPago;
            Boolean Existe = false;
            Console.WriteLine("Digite el numero de placa que desea consultar: ");
            numPlaca = int.Parse(Console.ReadLine());
            string op;

            for (int i = 0; i < 15; i++)
            {
                if (vehiculos[i].Equals(numPlaca))
                {
                    do
                    {  Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("1- Placa");
                        Console.WriteLine("2- Tipo de vehículo");
                        Console.WriteLine("3- Caseta");
                        Console.WriteLine("4- Salir");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Digite la opcion que desea modificar: ");
                        op = Console.ReadLine();

                        switch(op)
                        {     
                            case "1":
                                Console.Clear();
                                Console.Write("Actualice el numero de placa: ");
                                vehiculos[i] = int.Parse(Console.ReadLine()); 
                                break;
                            case "2":
                                Console.Write("Actualice el tipo de vehículo: ");
                                tipoVehiculo[i] = int.Parse(Console.ReadLine());
                                
                                break;
                            case "3":
                                Console.Write("Actualice la caseta: ");
                                caseta[i] = int.Parse(Console.ReadLine());
                                break;
                            case "4": break;
                            default:
                                Console.WriteLine("Opcion no es valida!!");
                                break;
                            }

                        } while(!op.Equals("4"));

                    Existe = true;
                    break;
                }

            }

            if (Existe == false)
            {
                Console.Clear();
                Console.WriteLine("Placa no existe");
            }

        }
        //public static void Reporte()
        //{
        //    Console.Clear();
        //    Console.WriteLine("********** Reporte de Estudiantes*************");
        //    for (int i = 0; i < estudiantes.Length; i++)
        //    {
        //        Console.WriteLine($"Nombre: {estudiantes[i]} Nota: {notas[i]}");
        //    }
        //    Console.WriteLine("********** Fin del reporte*************");
        //    Console.ReadLine();
        //}
    }
}




