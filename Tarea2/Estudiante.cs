using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class Estudiante
    {
        
        
            //ATRIBUTOS
            string[] cedula = new string[5];
            string[] nombre = new string[5];
        double[] promedio = new double[5];
        string[] condicion = new string[5];
            int pos;

            //CONSTRUCTOR
            public Estudiante() // constructor 
            {
                pos = 0;
            }
            public Estudiante(int posicion) // constructor 
            {
                pos = posicion;
            }

            public void InicializarVectores()
            {
                for (int i = 0; i < cedula.Length; i++)
                {
                    cedula[i] = "";
                    nombre[i] = "";
                promedio[i] = 0;
                condicion[i] = "";
                }
                Console.WriteLine("Arreglos inicializados...");

            }
            public void IncluirEstudiante()
            {
                char opcion;
                do
                {
                    Console.WriteLine("Digite su nombre: ");
                    nombre[pos] = Console.ReadLine();
                    Console.WriteLine("Digite su cedula");
                    cedula[pos] = Console.ReadLine();
                Console.WriteLine("Digite su promedio del Estudiante");
                promedio[pos] = double.Parse(Console.ReadLine());
                if (promedio[pos] >= 70)
                {
                    condicion[pos] = "Aprobado";
                } else
                {
                    condicion[pos] = "Desaprobado";
                }
                pos++;
                    Console.WriteLine("Desea continuar s/n");
                    opcion = Convert.ToChar(Console.ReadLine().ToUpper());
                } while (opcion != 'N');
            }

            
            public void ConsultarEstudiante()
            {
                Boolean existe = false;

                Console.WriteLine("Digite la cedula: ");
                string documento = Console.ReadLine();
                for (int i = 0; i < cedula.Length; i++)
                {
                    if (documento.Equals(cedula[i]))
                    {
                        Console.WriteLine($"El nombre del estudiante es {nombre[i]} y su promedio es {promedio[i]}");
                        existe = true;
                    }
                }
                if (!existe)
                {
                    Console.WriteLine("EL Estudiante no existe");
                    Console.WriteLine();
                }
            }


            public void ModificarEstudiante()
            {
            Console.WriteLine("Digite la cedula: ");
                string documento = Console.ReadLine();
                byte indice = 0;
                while (indice <= cedula.Length && !documento.Equals(cedula[indice]))
                {
                    indice++;
                }

                if (indice > cedula.Length)
                {
                    Console.WriteLine(" Cedula no existe");
                }
                else
                {
                    Console.WriteLine("Digite un nuevo nombre:");
                    nombre[indice] = Console.ReadLine();
                    Console.WriteLine("Digite una nueva cedula");
                    cedula[indice] = Console.ReadLine();
                Console.WriteLine("Digite una nuevo promedio");
                promedio[indice] = double.Parse(Console.ReadLine());
                


                }
            }
            public void BorrarEstudiante() {
            Console.WriteLine("Ingrese la cedula del estudiante: ");
            string codigo = Console.ReadLine();
            for (int i = 0; i < cedula.Length; i++)
            {
                if (cedula[i].Equals(codigo))
                {
                    nombre[i] = "";
                    cedula[i] = "";
                    condicion[i] = "";
                    promedio[i]=0;
                    Console.WriteLine("Estudiante Borrado");
                }
            }
        }

        public void ReporteEstudianteCondicion()
        {
            Console.WriteLine("Nombre    Condición ");
            Console.WriteLine("-------------------- ");
            for (int i = 0; i < cedula.Length; i++)
            {
                if (promedio[i] >= 70)
                {
                    Console.WriteLine($"{ nombre[i]}    {condicion[i]} ");

                }
                else
                {

                    

                    Console.WriteLine($"{ nombre[i]}    {condicion[i]} ");

                }
            }
            
        }

        public void ReporteEstudiante()
        {
            Console.WriteLine(" Cedula      Nombre        Promedio     Condición ");
            Console.WriteLine("-------------------------------------------------- ");
            for (int i = 0; i < cedula.Length; i++)
            {
                if (cedula[i].Length != 0)
                {
                    Console.WriteLine($"{cedula[i]}  { nombre[i]}   { promedio[i]}  {condicion[i]} ");

                }
            }
        }
    }
    
    }

