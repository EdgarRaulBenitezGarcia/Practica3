using System;
using System.Collections;

namespace Practica_3
{
    class Program
    {
        private Hashtable tabla;
                public Program()
        {
            tabla = new Hashtable();
        }
        public void agregarAlumno()
        {
            String nombre;
            String codigo;
            Console.Write("Nombre del alumno: ");
            nombre = Console.ReadLine();
            Console.Write("Codigo del alumno: ");
            codigo = Console.ReadLine();
            Alumno a = new Alumno(nombre, codigo);
            tabla.Add(codigo, a);
            Console.Clear();
        }
        public void verAlumnos()
        {
            Console.WriteLine("Alumnos Registrados\n");
            foreach (string codigo in tabla.Keys)
            {
                try
                {
                    
                    Object obj = tabla[codigo];
                    Alumno a = (Alumno)obj;
                    Console.WriteLine(a.getDatos());
                    

                }
                catch (Exception e)
                {
                    Console.WriteLine("Hay un Error en este dato");
                }
            }
            
        }

        public void eliminarAlumno()
        {
            String codigo;
            Console.Write("Codigo del alumno: ");
            codigo = Console.ReadLine();

            if (tabla.ContainsKey(codigo))
            {
                tabla.Remove(codigo);
                Console.WriteLine("eliminando a alumno con codigo : " + codigo);
                Console.ReadLine();
                Console.Clear();
            }
            else Console.WriteLine("No exixte este codigo " + codigo);
            Console.ReadLine();
            Console.Clear();

            
        }

        public static void Main(string[] args)
        {
            int opc;
            Program programa = new Program();
            do
            {
                Console.WriteLine("HashTable");
                Console.WriteLine("[1] Agregar Alumno");
                Console.WriteLine("[2] ver alumnos");
                Console.WriteLine("[3] Eliminar alumno");
                Console.WriteLine("[0] Salir");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1: programa.agregarAlumno();
                        break;
                    case 2: programa.verAlumnos();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3: programa.eliminarAlumno();
                        break;
                                    }
            } while (opc!=0);
        }
    }
}