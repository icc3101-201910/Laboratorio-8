using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_01_laboratorio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Round(4.25, 1, MidpointRounding.AwayFromZero));
            Console.WriteLine(Math.Round(4.245, 1, MidpointRounding.AwayFromZero));

            Console.WriteLine("Hey! Te ayudaré a mantener un promedio azul este semestre, avisándote cuando vayas bien o mal");
            Console.WriteLine("En cualquier momento puedes ingresar 0 y me callaré para siempre :c\n");

            // Ahora configuremos el Listado de notas con lo que piden...
            ListadoNotas jarvis = new ListadoNotas();
            jarvis.onAumento += ObservadorNotas.MostrarAumento;
            jarvis.onDisminucion += ObservadorNotas.MostrarDisminucion;

            while(true)
            {
                Console.WriteLine("\nIngresa una nota:");
                string opcion = Console.ReadLine();

                if (opcion == "0")
                {
                    Console.WriteLine("Adios :(");
                    break;
                }

                double nota;

                try
                {
                    nota = double.Parse(opcion);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Tienes que ingresar números!");
                    continue;
                }

                if (nota >= 1.0 && nota <= 7.0)
                {
                    jarvis.AgregarNota(nota);
                }
                else
                {
                    Console.WriteLine("Debes ingresar notas del 1 al 7");
                }
            }
        }
    }
}
