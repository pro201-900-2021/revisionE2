using System;
using System.Collections.Generic;// <==

namespace revisionE2
{
    class Program
    {//empieza la clase
        //Todo lo que esté en la función Main, se ejecutará.
        static void Main(string[] args)
        {
            int numero; //Int32//
            string palabra;
            double numeroGrande;

            //numero = "cadena";
            palabra = "cadena";

            //Vehiculo miVehiculo = new Vehiculo();
            //Desde aquí empieza la revisión
            bool ejecutando = true;

            Vehiculo v1 = new Vehiculo("Mazda", "3", 15000000, 10, 1);
            Vehiculo v2 = new Vehiculo("Subaru", "Impreza", 18000000, 5, 2);
            Vehiculo v3 = new Vehiculo("Toyota", "Yaris", 11000000, 20, 3);

            Vehiculo[] listaVehiculos = new Vehiculo[3] { v1, v2, v3 };

            List<Venta> listaVentas = new List<Venta>();

            while (ejecutando)
            {
                Console.WriteLine("VENTA DE VEHÍCULOS");
                Console.WriteLine("1.-Listar Vehículos");
                Console.WriteLine("2.-Vender Vehículos");
                Console.WriteLine("3.-Mostrar Ventas");
                Console.WriteLine("4.-Mostrar Dinero Recaudado");
                Console.WriteLine("5.-Vehículos Sin Stock");
                Console.WriteLine("6.-Salir");
                Console.Write("Introduzca Opción=> ");
                int opcion = Convert.ToInt32(Console.ReadLine());//2 => "2"
                //int opcion2 = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Lista de Vehículos");
                        
                        //foreach (tipo de dato (solo)
                        foreach(Vehiculo v in listaVehiculos)
                        {
                            
                            Console.WriteLine("["+v.Id+"]"+"Vehículo: "+v.Marca+" "+v.Modelo);
                            Console.WriteLine("Precio "+v.Precio);
                            Console.WriteLine("Stock "+v.Stock);
                        }

                        /*
                        Console.WriteLine("[" + listaVehiculos[0].Id + "]" + "Vehículo: " + listaVehiculos[0].Marca + " " + listaVehiculos[0].Modelo);
                        Console.WriteLine("Precio " + listaVehiculos[0].Precio);
                        Console.WriteLine("Stock " + listaVehiculos[0].Stock);

                        Console.WriteLine("[" + listaVehiculos[1].Id + "]" + "Vehículo: " + listaVehiculos[1].Marca + " " + listaVehiculos[1].Modelo);
                        Console.WriteLine("Precio " + listaVehiculos[1].Precio);
                        Console.WriteLine("Stock " + listaVehiculos[1].Stock);

                        Console.WriteLine("[" + listaVehiculos[2].Id + "]" + "Vehículo: " + listaVehiculos[2].Marca + " " + listaVehiculos[2].Modelo);
                        Console.WriteLine("Precio " + listaVehiculos[2].Precio);
                        Console.WriteLine("Stock " + listaVehiculos[2].Stock);
                        */
                        /*
                        for(int i = 0; i < listaVehiculos.Length; i = i + 1)
                        {
                            
                        }
                        */
                        break;
                    case 2:
                        //Descontar Stock
                        //Generar una venta
                        //Registrar esa venta
                        break;

                    case 3:

                        break;

                    case 4:

                        break;
                    case 5:
                        break;
                    case 6:
                        Console.WriteLine("Terminando el programa...");
                        ejecutando = false;
                        break;
                    default:
                        Console.WriteLine("Opción Ingresada no es válida");
                        break;
                }


            }



        }
    }//termina la clase
}
