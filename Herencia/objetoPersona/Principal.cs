using System;
using System.Security.AccessControl;
using libreriaClase;

namespace libreria
{

    class Pricipal{

        static void Main(){
            string opcion;
            System.Console.WriteLine("///////////");
            System.Console.WriteLine("Menu;");

            System.Console.WriteLine("Elija una opcion ");

            System.Console.WriteLine("1) Crear alumuno ");
            opcion=Console.ReadLine();
            if(opcion=="1")
            {
                CrearPesona();
            }
            else
            {
                System.Console.WriteLine("Opcion incorrecta");
            }

        }
        public static void CrearPesona()
        {
            Console.Clear();
            Persona p1=new Persona();

            System.Console.Write("Ingrese nombre: ");
            p1.Nombre=Console.ReadLine();
            System.Console.Write("Ingrese apellido: ");
            p1.Apellido=Console.ReadLine();
            System.Console.Write("Ingrese FechaDNacimiento");
            p1.FechaNacimiento=Console.ReadLine();
            System.Console.Write("Ingrese DNI");
            p1.DNI=Int32.Parse(Console.ReadLine());



        }

    }
    
}