using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_integrador
{
    internal class Funciones
    {
        public static void ingresodedatos(out string nombre, out string mail, out int edad, out string apellido) 
        {
            Console.WriteLine("ingresa tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("ingresa tu apellido");
            apellido = Console.ReadLine();
            Console.WriteLine("ingresa tu edad");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese su correo electronico");
            mail = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("<<<<<< Datos del Alumno>>>>>>");
            Console.WriteLine(nombre);
            Console.WriteLine(apellido);
            Console.WriteLine(edad);
            Console.WriteLine(mail);



        }

    }
}
