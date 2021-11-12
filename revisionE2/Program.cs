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
                        recorrerVehiculos(listaVehiculos);
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
                        //seleccionar vehículo a vender <-[]
                        //Descontar Stock <- []
                        //Generar una venta <-[]
                        //Registrar esa venta <-
                        Console.WriteLine("Seleccione un vehículo a vender");
                        recorrerVehiculos(listaVehiculos);
                        Console.Write("Opción=>");
                        int idActual = int.Parse(Console.ReadLine());
                        Vehiculo vehiculoActual = null;

                        //en este bloque foreach está la lógica poara seleccionar el vehiculo
                        foreach(Vehiculo v in listaVehiculos)
                        {
                            if(v.Id == idActual)
                            {
                                vehiculoActual = v;
                            }
                        }

                        //en este bloque pido la cantidad a vender
                        Console.Write("Cantidad a vender: ");
                        int cantidad = int.Parse(Console.ReadLine());

                        //aqui pregunto si es posible hacer la venta de acuerdo al stock
                        if(vehiculoActual.Stock - cantidad < 0)
                        {
                            //Aquí hacemos cosas, en caso de que la nueva cantidad sea negativa
                            Console.WriteLine("No se puede vender la cantidad ingresada.");
                        }
                        else //(vehiculoActual.Stock >= 0)
                        {
                            //Aquí hacemos cosas, en caso de que la nueva cantidad sea positiva
                            vehiculoActual.Stock = vehiculoActual.Stock - cantidad;
                            Venta estaVenta = new Venta(
                                vehiculoActual.Marca,
                                vehiculoActual.Modelo,
                                vehiculoActual.Precio,
                                cantidad);//Aca genero la venta
                            listaVentas.Add(estaVenta);//Registro la venta
                        }
                        break;

                    case 3:
                        Console.WriteLine("Listado de Ventas");
                        recorrerVentas(listaVentas);
                        break;

                    case 4:
                        Console.WriteLine("DINERO TOTAL RECAUDADO");
                        double totalRecaudado = 0;
                        foreach(Venta v in listaVentas)
                        {
                            totalRecaudado = totalRecaudado + (v.Cantidad * v.Precio);
                            //totalRecaudado += (v.Cantidad * v.Precio);
                        }
                        Console.WriteLine("Total Recaudado: $"+totalRecaudado);
                        break;
                    case 5:
                        int aux = 0;
                        bool hayVehiculosSinStock = false;
                        foreach (Vehiculo v in listaVehiculos)
                        {
                            
                            if(v.Stock == 0)
                            {
                                Console.WriteLine("[" + v.Id + "]" + "Vehículo: " + v.Marca + " " + v.Modelo);
                                Console.WriteLine("Precio " + v.Precio);
                                Console.WriteLine("Stock " + v.Stock);
                                aux += 1;
                                hayVehiculosSinStock = true;
                            }
                            

                        }
                        if (aux == 0)
                        {
                            Console.WriteLine("No hay vehiculos sin stock");
                        }
                        if (!hayVehiculosSinStock)
                        {
                            Console.WriteLine("No hay vehiculos sin stock");
                        }
                        
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

        private static void recorrerVehiculos(Vehiculo[] listaVehiculos)
        {
            foreach (Vehiculo v in listaVehiculos)
            {
                Console.WriteLine("[" + v.Id + "]" + "Vehículo: " + v.Marca + " " + v.Modelo);
                Console.WriteLine("Precio " + v.Precio);
                Console.WriteLine("Stock " + v.Stock);
            }
        }

        private static void recorrerVentas(List<Venta> listaVenta)
        {
            foreach(Venta v in listaVenta)
            {
                Console.WriteLine("********");
                Console.WriteLine(v);
                Console.WriteLine("********");
            }
        }

    }//termina la clase
}
