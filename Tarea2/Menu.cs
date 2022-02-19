using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{

    class Menu
    {
        static Estudiante estudiante = new Estudiante();

        public static void principal()
        {
            //Estudiante estudiante = new Estudiante();

            int opcion;
            do
            {
                Console.WriteLine("****** MENU PRINCIPAL ******");
                Console.WriteLine("1- Inicializar Arreglos");
                Console.WriteLine("2- Incluir Estudiantes");
                Console.WriteLine("3- Consultar Estudiantes");
                Console.WriteLine("4- Modificar Estudiantes");
                Console.WriteLine("5- Eliminar Estudiantes");
                Console.WriteLine("6- Submenú Reportes"  );
                Console.WriteLine("7- Salir");

                Console.WriteLine("Digite una opcion:" + (opcion = (int.Parse((Console.ReadLine())))));
                switch (opcion)
                {
                    case 1:
                        estudiante.InicializarVectores();
                        break;
                    case 2:
                        estudiante.IncluirEstudiante();
                        break;
                    case 3: estudiante.ConsultarEstudiante(); ; break;
                    case 4:
                        estudiante.ModificarEstudiante();

                        break;
                    case 5: estudiante.BorrarEstudiante(); ;
                        break;
                    case 6:
                        SubmenuReportes(); break;
                    default:
                        Console.WriteLine("Opcion Incorrecta");
                        break;
                }

            } while (opcion !=7);

        }



        public static void SubmenuReportes()
        {
            int option;
            do
            {
                Console.WriteLine("****** SUB MENU ******");
                Console.WriteLine("1- Reporte Estudiantes por Condición");
                Console.WriteLine("2- Reporte todos los datos");
                Console.WriteLine("3- Regresar Menu Principal");

                Console.WriteLine("Digite una opcion:" + (option = (int.Parse((Console.ReadLine())))));
                switch (option)
                {
                    case 1:


                        estudiante.ReporteEstudianteCondicion();

                        break;
                    case 2:
                        estudiante.ReporteEstudiante();
                        break;
                    case 3:
                    
                        principal();

                        break;

                    default:
                        Console.WriteLine("Opcion Incorrecta");
                        break;
                }

            } while (option !=4);

        }
    }

}

