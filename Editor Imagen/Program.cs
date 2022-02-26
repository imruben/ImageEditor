using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using BibliotecaImagen;

namespace Editor_Imagen
{
    // EDITOR DE IMAGEN: Programa de consola simple que nos permite ver y editar
    // una imagen a traves de consola (NO SIRVE PARA EL FORMS FINAL)

    class Program
    {

        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Bienvenido a tu editor de imagen");
            Console.WriteLine("");
            Console.WriteLine("Escoge un de las 2 opciones");
            Console.WriteLine("");
            Console.WriteLine("1) Cargar Imagen");
            Console.WriteLine("");
            Console.WriteLine("2) Salir");

             num = Convert.ToInt32(Console.ReadLine());


             if (num == 1)
             {
                Console.WriteLine("Ha escogido Cargar Imagen");
                Thread.Sleep(1000);
                Console.Clear();

                Imagen Laimagen = new Imagen();

                int err = Laimagen.CargarImagen("imagen.ppm");

                if (err == -1)
                   Console.WriteLine("No se ha encontrado el fichero");

                else if (err == -2)
                   Console.WriteLine("Formato incorrecto");

                else
                {
                    Console.WriteLine("La imagen se ha cargado correctamente");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("Presiona enter para continuar");
                    Console.Clear();
                    Console.WriteLine("1) Mostrar Cabecera");
                    Console.WriteLine("2) Mostrar Directorio");
                    Console.WriteLine("3) Mostrar Tamaño en pixeles");
                    Console.WriteLine("4) Mostrar Imagen");
                    Console.WriteLine("5) Voltear Imagen");
                    Console.WriteLine("6) Modificar el valor de un color de un pixel");
                    Console.WriteLine("7) Salir");


                    num = Convert.ToInt32(Console.ReadLine());

                    if(num == 1)
                    {
                        Console.Clear();
                        Laimagen.MostrarCabecera();
                    }
                    if (num == 2)
                    {
                        Console.Clear();
                        Laimagen.MostrarDirectorio();
                    }
                    if (num == 3)
                    {
                        Console.Clear();
                        Laimagen.Tamaño();
                    }
                    if (num == 4)
                    {
                        Console.Clear();
                        Laimagen.MostrarImagen();
                    }
                    if (num == 5)
                    {
                        Console.Clear();
                        Laimagen.VoltearImagen();
             
                    }
                    /*if (num == 6)
                    {
                        Console.Clear();
                        Laimagen.ModificarColor();

                    }*/
                  
                    if (num == 7)
                    {
                        Console.Clear();
                        Console.WriteLine("Ha escogido Salir");
                        Console.WriteLine("");
                        Console.WriteLine("Adios");
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                    }
                }
                 
                    Console.ReadKey();

             }

             if (num == 2)
             {
                 Console.Clear();
                 Console.WriteLine("Ha escogido Salir");
                 Console.WriteLine("");
                 Console.WriteLine("Adios");
                 Thread.Sleep(1000);
                 Environment.Exit(0);
             }

        }
    }
}
