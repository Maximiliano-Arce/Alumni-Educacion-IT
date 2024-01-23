using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_integrador
{
    internal class Program
    {
        static void Main(string[] args)
        {   string nombre, mail, apellido;
            string confirmacion;
            int carrera, edad;
            string [] cursos = new string[5];
            string decision;


            Funciones.ingresodedatos(out nombre, out mail, out edad, out apellido);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("los datos son correctos");
            Console.WriteLine("ingrese S/N");
            confirmacion = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();

            if (confirmacion == "S")
            {
                Console.WriteLine("<<<<<<<<seleccione el codigo de la carrera elegida>>>>>>");
                Console.WriteLine(" 1 . Programacion.Net");
                Console.WriteLine(" 2 . Programacion Java");
                Console.WriteLine(" 3 . Programacion PHP");

                carrera = int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine();

                if(carrera == 1)
                {
                        Console.WriteLine("<<<<<<<< los cursos para la siguiente carrera son >>>>>>>>");
                        Console.WriteLine("1. Nivel 1");
                        Console.WriteLine("2. Nivel 2");
                        Console.WriteLine("3. Nivel 3");
                        Console.WriteLine("4. Nivel 4");
                        Console.WriteLine("5. Nivel 5");

                        Console.WriteLine();
                        Console.WriteLine();

                    //    for (int i = 0; i < 5; i++)

                    //{
                    //    Console.WriteLine("ingrese los cursos seleccionados");
                    //    cursos[i] = Console.ReadLine();

                    //    do
                    //    {
                    //        Console.WriteLine("<<<<< desea seguir cargando cursos??? >>>>>");
                    //        decision = Console.ReadLine();
                    //        if(decision == "N") 
                    //        {
                    //            break;


                    //        }

                    //    } while (decision == "S");

                    //}


                    int indice = 0;

                    do
                    {
                        
                        Console.WriteLine("ingrese los cursos seleccionados");
                        cursos[indice] = Console.ReadLine();

                        Console.WriteLine("<<<<< desea seguir cargando cursos??? >>>>>");
                        decision = Console.ReadLine();
                        if (decision == "N")
                        {
                            break;


                        }
                        indice++;

                    } while (decision != "N" || indice >= 5);

                    Console.WriteLine();
                    Console.WriteLine();

                    //for( i = 0; i < cursos.Length; i++) 

                    //{
                    //    if (cursos[i] != null) 
                    //    {



                    //        Console.WriteLine($"Curso {i + 1}: Nivel {cursos[i]}");
                    //    }




                    //}

                    //string resultado = string.Empty;

                    //for (i = 0; i < cursos.Length; i++)
                    //{
                    //    if (cursos[i] != null)
                    //    {
                    //        resultado = resultado + $"Nivel: {cursos[i]}, ";
                    //    }
                    //}


                    Console.ReadKey();  

                }
                if(carrera == 2) 
                {
                    Console.WriteLine("<<<<<<<< Los cursos para la siguiente carrera son >>>>>>>>");
                    Console.WriteLine("1. Nivel 1");
                    Console.WriteLine("2. Nivel 2");
                    Console.WriteLine("3. Nivel 3");
                    Console.WriteLine("4. Nivel 4");
                    Console.WriteLine("5. Nivel 5");

                    Console.WriteLine();
                    Console.WriteLine();

                    int indice = 0;

                    do
                    {

                        Console.WriteLine("ingrese los cursos seleccionados");
                        cursos[indice] = Console.ReadLine();

                        Console.WriteLine("<<<<< desea seguir cargando cursos??? >>>>>");
                        decision = Console.ReadLine();
                        if (decision == "N")
                        {
                            break;


                        }
                        indice++;

                    } while (decision != "N" || indice >= 5);


                }
                if (carrera == 3) 
                {
                    Console.WriteLine("<<<<<<<< Los cursos para la siguiente carrera son >>>>>>>>");
                    Console.WriteLine("1. Nivel 1");
                    Console.WriteLine("2. Nivel 2");
                    Console.WriteLine("3. Nivel 3");
                    Console.WriteLine("4. Nivel 4");
                    Console.WriteLine("5. Nivel 5");

                    Console.WriteLine();
                    Console.WriteLine();

                    int indice = 0;

                    do
                    {

                        Console.WriteLine("ingrese los cursos seleccionados");
                        cursos[indice] = Console.ReadLine();

                        Console.WriteLine("<<<<< desea seguir cargando cursos??? >>>>>");
                        decision = Console.ReadLine();
                        if (decision == "N")
                        {
                            break;


                        }
                        indice++;

                    } while (decision != "N" || indice >= 5);


                }

                Console.WriteLine();
              


                switch (carrera)

                {
                    case 1:
                        Console.WriteLine("<<<<<Constancia de inscripcion>>>>>");
                        Console.WriteLine("Alumno: " + nombre);
                        Console.WriteLine("Correo: " + mail);
                        Console.WriteLine("1 . Programacion.Net");
                        Console.WriteLine("comienza la carrera con los siguientes cursos");
                        //string cursoselegidos = string.Join("Nivel: ", cursos);
                        //Console.WriteLine($"Curso : {cursoselegidos}");
                        string resultado = string.Empty;

                        for (int i = 0; i < cursos.Length; i++)
                        {
                            if (cursos[i] != null)
                            {
                                resultado = resultado + $"Nivel: {cursos[i]} ";
                            }
                        }

                        Console.WriteLine(resultado);


                        break;

                    case 2:

                        Console.WriteLine("<<<<<Constancia de inscripcion>>>>>");
                        Console.WriteLine("Alumno: " + nombre);
                        Console.WriteLine("Correo: " + mail);
                        Console.WriteLine("2 . Programacion JAVA");
                        Console.WriteLine("Comienza la carrera con los siguientes cursos");

                        string resultado2 = string.Empty;

                        for (int i = 0; i < cursos.Length; i++)
                        {
                            if (cursos[i] != null)
                            {
                                resultado2 = resultado2 + $"Nivel: {cursos[i]} ";
                            }
                        }

                        Console.WriteLine(resultado2);


                        break;

                        

                    case 3:

                        Console.WriteLine("<<<<<Constancia de inscripcion>>>>>");
                        Console.WriteLine("Alumno: " + nombre);
                        Console.WriteLine("Correo: " + mail);
                        Console.WriteLine("3 . Programacion PHP");
                        Console.WriteLine("Comienza la carrera con los siguientes cursos");

                        string resultado3 = string.Empty;

                        for (int i = 0; i < cursos.Length; i++)
                        {
                            if (cursos[i] != null)
                            {
                                resultado3 = resultado3 + $"Nivel: {cursos[i]} ";
                            }
                        }

                        Console.WriteLine(resultado3);


                        break;

                    default:

                        Console.WriteLine("Carrera inexistente");
                        Console.WriteLine("Datos incorrectos, Ejecutar Nuevamnte la aplicacion");
                        break;

                }



            }
            else
            {
                Console.WriteLine("Entrada inválida para el código de la carrera.");
                Console.WriteLine("Datos incorrectos, Ejecutar nuevamente la aplicacion");


            }










        }
    }
}
