using System;

namespace L12_RAJCL_1073522
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa de notas con vectores");
            pruebaVector pv = new pruebaVector();
            pv.Cargar();
            pv.Imprimir();
        }

        class pruebaVector
        {
            private int[] Notas;
            public int suma = 0;
            public int NoDatos = 15;

            public void Cargar()
            {
                Notas = new int[15];
                for (int f = 0; f < 15; f++)
                {
                    Console.WriteLine("Ingrese una nota: ");
                    string linea;
                    linea = Console.ReadLine();
                    Notas[f] = int.Parse(linea);
                    suma = suma + Notas[f];
                }
            }
            public void Imprimir()
            {
                for (int f = 0; f < 15; f++)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Se ingreso ");
                    Console.WriteLine(Notas[f]);
                }
                Console.WriteLine("La suma de todas las notas es: " + suma);
                Console.WriteLine("La media (promedio) es de: " + suma / NoDatos);
                Console.ReadKey();
            }

        }
    }
}