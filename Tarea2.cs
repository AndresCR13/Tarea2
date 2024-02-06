using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Menu
    {
        public static int opcion;
        public static void menu()
        {
            try
            {
                do
                {
                    Console.WriteLine("1- Agregar Productos");
                    Console.WriteLine("2- Venta de Productos");
                    Console.WriteLine("3- Actualizar Productos");
                    Console.WriteLine("4- Actualizar Precio");
                    Console.WriteLine("5- Borrar producto");
                    Console.WriteLine("6- Reporte");
                    Console.WriteLine("7- Salir");
                    Console.WriteLine("Digite una opcion...");
                    opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1: Producto.Agregar(); break;
                        case 2: Producto.VenderProducto(); break;
                        case 3: Producto.ActualizarProducto(); break;
                        case 4: Producto.ActualizarPrecio(); break;
                        case 5: Producto.BorrarProducto(); break;
                        case 6: Producto.Reporte(); break;

                        default: Console.WriteLine("Adios...Vuelva pronto!"); break;
                    }
                } while (opcion != 7);
            }
            catch (Exception )
            {
                Console.WriteLine("Digito mal el codigo");
            }
            
        } 
    }
    
}   
